namespace Pr3_3_Up_Uporov
{
    internal static class Program
    {
        static void Main()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                using (var formLogin = new FormLogin())
                {
                    if (formLogin.ShowDialog() == DialogResult.OK)
                    {
                        using (var formTovars = new FormTovars(
                            formLogin.CurrentUser,
                            formLogin.IsGuest))
                        {
                            if (formTovars.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                            else
                            {
                                exitProgram = true;
                            }
                        }
                    }
                    else
                    {
                        exitProgram = true;
                    }
                }
            }
        }
    }
}