using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                    //because of FileStream
using System.Runtime.Serialization.Formatters.Binary; //because of BinaryFormatter
using System.Runtime.Serialization; //because of SerializationException
using System.Windows.Forms;

namespace Traffic_Advisor
{
    class FileHelper
    {
        public static List<string> GettingManual()
        {
            FileStream fs = new FileStream("Manual.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<string> manual = new List<string>();
            string s = sr.ReadLine();
            while (s != null)
            {
                manual.Add(s);
                s = sr.ReadLine();
            }
            sr.Dispose();
            fs.Dispose();
            return manual;
        }

        public static void SaveToFile(string filepath, Simulation m)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            fs.SetLength(0);
            bf.Serialize(fs, m);
            fs.Dispose();
        }

        public static Simulation LoadFromFile(string filepath)
        {
            Simulation mani = new Simulation();
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                if (fs.Length == 0)
                    mani = null;
                else
                    mani = (Simulation)bf.Deserialize(fs);
                fs.Dispose();
                return mani;
            }
            catch (Exception)
            {
                MessageBox.Show("Not a valid file!");
                return null;
            }
        }
    }
}
