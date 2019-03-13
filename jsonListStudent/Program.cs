using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonListStudent
{
    class Program
    {
        static void Main(string[] args)
        {
                      
          // string jsonsave1 = JsonConvert.SerializeObject(st1,Formatting.Indented);
          // File.WriteAllText(@"C:\Users\albana\Desktop\Genti\json\jsonsave.json", JsonConvert.SerializeObject(st2, Formatting.Indented));
          // string jsonsave2 = JsonConvert.SerializeObject(st2,Formatting.Indented);

          //  Console.WriteLine(jsonsave1);
          //  Console.WriteLine("\n");
          //  Console.WriteLine(jsonsave2);
            //Dictionary<string, int> piket = new Dictionary<string, int>
            //{
            //    {"Albana",100 },
            //    {"Gentjan",85 }

            //};
            //string jsonpiket = JsonConvert.SerializeObject(piket, Formatting.Indented);
            //Console.WriteLine(jsonpiket);
            List<student> studentat = new List<student>
            {
                new student
                { fName = "Albert",
                    lName = "Ainstein",
                    age = 30,
                    TeDhenaPergjithesuese = new List<TePergjithshme>
                    {
                        new TePergjithshme()
                        {
                            email ="ainstainAlbert@gmail.com",
                            country ="Germany",
                            telNumber="00000000000",
                            gender="Male"
                        }

                    }
                },
                new student
                { fName = "Albert",
                    lName = "Kamy",
                    age = 60,
                    TeDhenaPergjithesuese = new List<TePergjithshme>
                    {
                        new TePergjithshme()
                        {
                            email ="KamyAlbert@gmail.com",
                            country ="United State",
                            telNumber="111111111",
                             gender="Male"
                        }

                    }
                },
                new student
                { fName = "Nikollai",
                    lName = "Gogol",
                    age = 54,
                    TeDhenaPergjithesuese = new List<TePergjithshme>
                    {
                        new TePergjithshme()
                        {
                            email ="NikollaiGogol@gmail.com",
                            country ="Rusia",
                            telNumber="222222222",
                             gender="Male"
                        }

                    }
                },
                new student
                {
                fName = "Albana",
                lName = "Sufaj",
                age = 36,
                TeDhenaPergjithesuese = new List<TePergjithshme>
                {
                    new TePergjithshme()
                    {
                        email ="albana.sufaj@gmail.com",
                        country ="Albania",
                        telNumber="068 80 87 218",
                         gender="Female"
                    }

                }
                },
                new student
                {
                      fName = "Gentjan",
                lName = "Mehmetaj",
                age = 36,
                TeDhenaPergjithesuese = new List<TePergjithshme>
                {
                    new TePergjithshme()
                    {
                        email ="gent.mehmetaj@gmail.com",
                        country ="Albania",
                        telNumber="069 40 49 178",
                         gender="Male"
                    }

                }
                }
            };
            File.WriteAllText(@"C:\Users\albana\Desktop\Genti\json\studentat.json", JsonConvert.SerializeObject(studentat, Formatting.Indented));
            string listST = JsonConvert.SerializeObject(studentat, Formatting.Indented);
            List<student> listStudetash = JsonConvert.DeserializeObject<List<student>>(listST);
            foreach (var st in listStudetash)
            {
                Console.WriteLine(st.fName);
                Console.WriteLine(st.lName);
                Console.WriteLine(st.age);
                foreach (var el in st.TeDhenaPergjithesuese)
                {
                    Console.WriteLine(el.email);
                    Console.WriteLine(el.country);
                    Console.WriteLine(el.telNumber);
                    Console.WriteLine("\n");
                }
            }
            Console.ReadLine();
               
                
        }
    }
}
