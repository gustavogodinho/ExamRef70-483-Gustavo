using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LISTING_1_9_Using_a_Task_that_returns_a_value
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<NotaFiscal> notaFiscal = new List<NotaFiscal>
            {
                new NotaFiscal { NUM_DOC = 10001, IND_NF = 1, DT_DOC = DateTime.Now.Date, VL_DOC = 105360.20 },
                new NotaFiscal { NUM_DOC = 10890, IND_NF = 0, DT_DOC = DateTime.Now.Date, VL_DOC = 10810 },
                new NotaFiscal { NUM_DOC = 10120, IND_NF = 0, DT_DOC = DateTime.Now.Date, VL_DOC = 10910 },
                new NotaFiscal { NUM_DOC = 11201, IND_NF = 1, DT_DOC = DateTime.Now.Date, VL_DOC = 10550 }
            };

            string json = @"{
                            'Email': 'james@example.com',
                            'Active': true,
                            'CreatedDate': '2013-01-20T00:00:00Z',
                            'Roles': [
                            'User',
                            'Admin'
                          ]
                        }";


            Task<string> account = Task.Run(() =>
            {
                return json;
            });

            //Json para Objeto
            Account ac = JsonConvert.DeserializeObject<Account>(json);

            Console.WriteLine(ac.Email);
            Console.WriteLine(ac.CreatedDate);



            Task<NotaFiscal> nota = Task.Run(() =>
            {
                return notaFiscal[0];
            });

            //Objeto para Json
            string resultNota = JsonConvert.SerializeObject(nota.Result);

            Console.WriteLine(resultNota);



            Task<int> t = Task.Run(() =>
            {
                return 42;
            });



            Console.WriteLine(t.Result);
            Console.ReadKey();
        }

        public class NotaFiscal
        {
            public int NUM_DOC { get; set; }
            public int IND_NF { get; set; }
            public DateTime DT_DOC { get; set; }
            public double VL_DOC { get; set; }

        }

        public class Account
        {
            public string Email { get; set; }
            public bool Active { get; set; }
            public DateTime CreatedDate { get; set; }
            public IList<string> Roles { get; set; }
        }


    }

}
