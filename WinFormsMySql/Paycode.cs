namespace WinFormsMySql
{
    internal class Paycode
    {
        public int Paycodeid { get; set; }
        public string Paycodename { get; set; }

        public Paycode(int paycodeid, string paycodename = "<?>")
        {
            Paycodeid = paycodeid;
            Paycodename = paycodename;
        }

        public static Paycode GetClone(Paycode paycode)
        {
            if (paycode is null)
                throw new System.ArgumentNullException(nameof(paycode));

            return new Paycode(paycode.Paycodeid)
            {
                Paycodename = paycode.Paycodename
            };
        }
    }
}
