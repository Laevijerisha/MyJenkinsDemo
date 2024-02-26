namespace JenkisDemo
{
    public class Testme
    {
        public String sayJenkins(int times)

        {
            string Output = "";
            for (int i = 0; i < times; i++)
            {
                Output += "Jenkins";
            }
            return Output;
        }
    }
}
