using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMySql
{
    internal class Cars
    {
        public int Carid { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string Btdate { get; set; }
        public string Transmission { get; set; }
        public int Engcap { get; set; }
        public string Wheeloc { get; set; }
        public string Body { get; set; }
        public int Doornumb { get; set; }
        public string Regnumb { get; set; }
        public string Regnumbreg { get; set; }
        public int Instructorsfk { get; set; }

        public Cars(int carid, string vendor = "<?>", string model = "<?>", string btdate = "<?>",
            string transmission = "<?>", int engcap = 0, string wheeloc = "<?>", string body = "<?>",
            int doornumb = 0, string regnumb = "<?>", string regnumbreg = "<?>", int instructorsfk = 0)
        {
            Carid = carid;
            Vendor = vendor;
            Model = model;
            Btdate = btdate;
            Transmission = transmission;
            Engcap = engcap;
            Wheeloc = wheeloc;
            Body = body;
            Doornumb = doornumb;
            Regnumb = regnumb;
            Regnumbreg = regnumbreg;
            Instructorsfk = instructorsfk;
        }

        public static Cars GetClone(Cars cars)
        {
            if (cars is null)
                throw new System.ArgumentNullException(nameof(cars));

            return new Cars(cars.Carid)
            {
                Vendor = cars.Vendor,
                Model = cars.Model,
                Btdate = cars.Btdate,
                Transmission = cars.Transmission,
                Engcap = cars.Engcap,
                Wheeloc = cars.Wheeloc,
                Body = cars.Body,
                Doornumb = cars.Doornumb,
                Regnumb = cars.Regnumb,
                Regnumbreg = cars.Regnumbreg,
                Instructorsfk = cars.Instructorsfk
            };
        }
    }
}
