using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace department_class
{
    class department
    {
        public int id;
        public string name;
        public int departmentcount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<department> data= new List<department>()
            {
             new department() { id=10,name="coiding",departmentcount=60},
             new department() { id=20,name="testing",departmentcount=30},
             new department() { id=30,name="analyst",departmentcount=40},
             new department() { id=40,name="BA",departmentcount=80},
             };

            //using for loop
            for(int i=0;i<data.Count; i++)
            {
                if(data[i].departmentcount>50)
                    Console.WriteLine($"id ={data[i].id},name={data[i].name}");

            }
            //using foreach

            foreach( var d in data)
            {
                if (d.departmentcount>50)
                    Console.WriteLine($"id={d.id},name={d.name}");
            }

            //lamda function
            data.Where(d=>d.departmentcount>50).ToList().ForEach(d =>Console.WriteLine($" id={d.id},name={d.name} "));


            //linq function
            var result = from d in data
                         where d.departmentcount>50
                         select d;

            result.ToList().ForEach(d =>Console.WriteLine($" id={d.id},name={d.name} "));

            Console.ReadLine();
            

            }


        }
    }

