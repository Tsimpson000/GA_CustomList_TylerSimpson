namespace GA_CustomList_TylerSimpson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom List Class Example");
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Hello");
            myList.AddAtIndex("World \n", 1);
            //more testing code
            for (int i = 0; i < myList.Count; i++)
            {
                
                Console.WriteLine(myList.GetItem(i));
            }
            myList.Remove(myList.GetItem(1));
            myList.AddAtIndex("Will!", 1);
            for (int i = 0; i < myList.Count; i++)
            {

                Console.WriteLine(myList.GetItem(i));
            }
        }
    }
}
