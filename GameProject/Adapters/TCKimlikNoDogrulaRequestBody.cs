namespace GameProject.Adapters
{
    internal class TCKimlikNoDogrulaRequestBody
    {
        private long v1;
        private string v2;
        private string v3;
        private int birthYear;

        public TCKimlikNoDogrulaRequestBody(long v1, string v2, string v3, int birthYear)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.birthYear = birthYear;
        }
    }
}