using System.Runtime.InteropServices;
using System.Text;

namespace Assignment_6._1
{
    internal class Program
    {
       
        static int RandomNumber(HouseLinkedList hl)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, 9999);

            while(hl.Search(result)) { result = rnd.Next(1, 9999); }

            return result;
        }
        static string RandomString() 
        {

            string[] array = {"Maple", "Oakridge", "Willow", "Harbor View",
                "Cedar Crest", "Elmwood", "Sunset", "Birchwood", "Riverside",
                "Chestnut Hill", "Magnolia", "Pinecrest", "Foxglove", "Lakeshore",
                "Hawthorne", "Meadowbrook", "Stonegate", "Juniper", "Briarcliff",
                "Kingsbury"};

            string[] suffix = {  "Street", "Avenue", "Road", "Lane", "Drive",
                "Court", "Boulevard", "Way", "Place", "Circle", "Terrace", "Parkway",
                "Trail", "Highway", "Square" };

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            sb.Append(array[rnd.Next(0, array.Length)]);

            while(rnd.Next(0, 1) == 1)
            {
                sb.Append(" " + array[rnd.Next(0, array.Length)]);
            }

            sb.Append(" " + suffix[rnd.Next(0, suffix.Length)]);

            return sb.ToString();
        }

        static string RandomType()
        {
            string[] type = { "Ranch", "Colonial", "Victorian", "Craftsman",
                "Cape Cod", "Tudor", "Bungalow", "Split-Level",
                "Farmhouse", "Mediterranean", "Contemporary", "Modern",
                "Townhouse", "Cottage", "Georgian", "Mid-Century Modern",
                "Duplex", "Log Cabin", "Chalet", "Condo"};
            
            Random rnd = new Random();

            return type[rnd.Next(0, type.Length)];
        }
        static void LinkedHouse()
        {
            HouseLinkedList houseList = new HouseLinkedList();

            houseList.AddFirst(RandomNumber(houseList), RandomString(), RandomType());
            houseList.AddLast(RandomNumber(houseList), RandomString(), RandomType());
            houseList.AddLast(RandomNumber(houseList), RandomString(), RandomType());
            houseList.AddLast(RandomNumber(houseList), RandomString(), RandomType());
            houseList.AddLast(RandomNumber(houseList), RandomString(), RandomType());
            houseList.AddLast(RandomNumber(houseList), RandomString(), RandomType());
            houseList.AddLast(RandomNumber(houseList), RandomString(), RandomType());

            houseList.DisplayHouseNumbers();
            Console.Write("Please enter the full house number you would like to view: ");

            int number;
            while (!int.TryParse(Console.ReadLine(), out number)) ;

            if (houseList.Search(number))
            {
                houseList.Display(number);
            }

        }

        static void ArrayInPlace(int[] nums)
        {
            int noneZero = 0;
            for (int y = 0; y < nums.Length; y++)
            {
                if (nums[y] != 0)
                {
                    int temp = nums[noneZero];
                    nums[noneZero] = nums[y];
                    nums[y] = temp;
                    noneZero++;
                }
            }
                
        }

        static void Print()
        {

            LinkedHouse();

            int[] nums = { 0, 1, 0, 3, 12 };
            Console.Write("\nThis is program pushed the zeros to the back and keep the other numbers in order!\nOriginal: ");
            foreach (int x in nums)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();

            ArrayInPlace(nums);
            Console.Write("Changed: ");
            foreach (int x in nums)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Print();
        }
    }
}
