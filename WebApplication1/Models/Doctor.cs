namespace WebApplication1.Models
{
    public class Doctor
    {
        public static string CheckFever(double temp)
        {

            if (temp >=38)
            {
                return "You have got fever.";
            }
            else if (temp <= 35 && temp > 0)
            {
                return "You have got hypothermi.";
            }

            return "You are fine, NOT having fever.";
        }
    }
}
