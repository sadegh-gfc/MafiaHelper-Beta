using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaHelper
{
   public class SaveInformation
   {
        public string Shot;
        public string Save;
        public string Negahbani;
        public string GeroganGirir;
        public string GunJangi;
        public string GunMashghi;
        public string Mozakere;
        public string Estelam;

        


        public static bool IsGhadim = false;
        //public static bool DoesItHaveExistFile = false;
        public static int GameNum = 1;

        public static List<SaveInformation> ContactList = new List<SaveInformation>();

        public static string path = @"";

        public static string pathOriginal;
        
        public static string GameName;

        

        public static void OperationSave()
        {
            string textForSave = "";               
            for (int i = 0; i < ContactList.Count; i++)
            {
                SaveInformation c1 = ContactList[i];
                textForSave += "Day: " + Convert.ToString(i + 1) + Convert.ToString('\n');
                textForSave += "Shot is: " + c1.Shot;
                textForSave +=  Environment.NewLine;
                textForSave += "Save is: " + c1.Save;
                textForSave += Environment.NewLine;
                textForSave += "Karagah Estelam is: " + c1.Estelam;
                textForSave += Environment.NewLine;
                if (SaveInformation.IsGhadim == true)
                {
                    textForSave += "Mozakere is : " + c1.Mozakere + '\n';
                    textForSave += "================================" + '\n';
                }
                else
                {
                    textForSave += "Gerogangiri is: " + c1.GeroganGirir;
                    textForSave += Environment.NewLine;
                    textForSave += "Negahbani is: " + c1.Negahbani;
                    textForSave += Environment.NewLine;
                    textForSave += "Gun Jangi is For: " + c1.GunJangi;
                    textForSave += Environment.NewLine;
                    textForSave += "Gun Mashgi is For: " + c1.GunMashghi;
                    textForSave += Environment.NewLine;
                    textForSave += "=======================" + '\n';
                }
                
            }
            GameNum = 1;
            pathOriginal = path + "\\" + GameName + ".txt";
            textForSave += "▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬";
            try
            {
                System.IO.File.WriteAllText(pathOriginal, textForSave);
            }
            catch
            {
                
            }
        }

        public static void Load()
        {
            string[] splited;
            string AllText;

           
                AllText = System.IO.File.ReadAllText(path);
                splited = AllText.Split(Convert.ToChar("\n"));


                for (int i = 0; i < AllText.Length; i += 4)
                {
                    SaveInformation c1 = new SaveInformation();

                    c1.Shot = splited[i];
                    c1.Save = splited[i + 1];
                    c1.GeroganGirir = splited[i + 2];
                    c1.Negahbani = splited[i + 3];
                    c1.GunJangi = splited[i + 4];
                    c1.GunMashghi = splited[i + 5];
                    ContactList.Add(c1);
                }
        }
        public static void ClearFolder()
        {
            System.IO.File.Delete(path);
        }
   }

}
