using System.Text;
namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            if (!Directory.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo"))
            {
                Directory.CreateDirectory(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo");
                Console.WriteLine("Directory of Demo is Created");

            }
            if (!Directory.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1"))
            {
                Directory.CreateDirectory(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1");
                Console.WriteLine("Directory of Demo 1 Created");

            }
            if (!Directory.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo2"))
            {
                Directory.CreateDirectory(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo2");
                Console.WriteLine("Directory of Demo 2 Created");

            }
            if (!File.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1\file.txt"))
            {
                File.Create(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1\file.txt");
                Console.WriteLine("File is Created with File");
            }
            FileInfo fs = new FileInfo(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1\fileinfo.txt");
            if (!fs.Exists)
            {
                fs.Create();
                Console.WriteLine("File From fileInfo is Created");
            }
            File.WriteAllText(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1\file.txt", "This is MyFirst File");



            if (!File.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo2\file.txt"))
            {
                File.Copy(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1\file.txt", @"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo2\file.txt");
            }

            string[] list = Directory.GetFiles(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1");
            foreach (string file in list)
            {
                Console.WriteLine(Path.GetFullPath(file) + " " + Path.GetFileName(file));
                Console.WriteLine(File.GetCreationTime(file).ToLongDateString());
            }


            // Deleting the files

            //file  is deleted

            //if (File.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1\file.txt"))
            //{
            //    File.Delete(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1\file.txt");
            //}

            ////fileinfo file is deleted

            //if (File.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1\fileinfo.txt"))
            //{
            //    File.Delete(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1\fileinfo.txt");
            //}

            ////file in demo 2 is deleted which was copied
            //if (File.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo2\file.txt"))
            //{
            //    File.Delete(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo2\file.txt");
            //}

            //deleting the directories

            //Demo 1 is deleted

            //if(Directory.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1"))
            //{
            //    Directory.Delete(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo1");
            //}

            //Demo 2 is deleted

            //if (Directory.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo2"))
            //{
            //    Directory.Delete(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo\Demo2");
            //}

            //Demo  is deleted

            //if (Directory.Exists(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo"))
            //{
            //    Directory.Delete(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\Demo");
            //}



            //Task 2
            //Creating a File
            //FileStream fs = new FileStream(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\task2\task2.txt", FileMode.Create);
            //StreamWriter writer = new StreamWriter(fs);

            ////Adding Contents to the file
            //writer.WriteLine("This is My First Text");
            //writer.Close();
            //fs.Close();

            ////Appending contents
            //fs = new FileStream(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\task2\task2.txt", FileMode.Append);
            //StreamWriter write= new StreamWriter(fs);
            //write.WriteLine("Appended Succesfully");
            //write.Close();
            //fs.Close();

            ////Displaying All the contents Together
            //fs = new FileStream(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\task2\task2.txt", FileMode.Open, FileAccess.Read);
            //StreamReader read= new StreamReader(fs);
            //Console.WriteLine(read.ReadToEnd());

            ////Display Content one by one
            //fs = new FileStream(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\task2\task2.txt", FileMode.Open, FileAccess.Read);
            //StreamReader read2 = new StreamReader(@"C:\Users\Jatin.Bhola\Desktop\assignment\Assignment7FileHandling\task2\task2.txt");
            //string line = read2.ReadLine();
            //while (line != null)
            //{
            //    Console.WriteLine(line);
            //    line = read2.ReadLine();
            //}
        }


    }
}