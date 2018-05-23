using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Pool.Usercontrols
{
    public partial class Uc_Stand : UserControl
    {
        SerialPort myport = new SerialPort();
        int rood = 0;
        int groen = 0;
        int geel = 0;
        int blauw = 0;
        int bordeaux = 0;
        int paars = 0;
        int oranje = 0;

        int halfgroen = 0;
        int halfrood = 0;
        int halfblauw = 0;
        int halfgeel = 0;
        int halfpaars = 0;
        int halfbordeaux =
            0;
        int halforanje = 0;
        
        public Uc_Stand()
        {
            InitializeComponent();
            myport.BaudRate = 9600;
            myport.PortName = "COM8";

        }

        private void Gbx_SpelerLinks_Enter(object sender, EventArgs e)
        {
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            myport.Open();
            string data = myport.ReadLine();
            if (!data.Contains("Niks"))
            {
                for (int i = 0; i < 100000; i++)
                {
                    data = myport.ReadLine();

                    //einde
                    if (data.Contains("Eind"))
                    {
                        myport.Close();
                        break;
                    }




                    //geel
                    if (data.Contains("sig: 1"))
                    {
                        int totalLength = data.Length;
                        if (totalLength > 50)
                        {
                            string sub = data.Substring(38, 4);
                            int result;
                            if (int.TryParse(sub, out result))
                            {
                                int Width = Convert.ToInt32(sub);
                                if (Width < 30)
                                {
                                    Pb_Bal9.Visible = true;
                                    halfgeel = 0;
                                }
                                else
                                {
                                    halfgeel++;
                                    if (halfgeel > 10)
                                    {
                                        Pb_Bal9.Visible = false;
                                    }
                                }
                                if (Width >= 30)
                                {
                                    Pb_Bal1.Visible = true;
                                    geel = 0;
                                }
                                else
                                {
                                    geel++;
                                    if (geel > 10)
                                    {
                                        Pb_Bal1.Visible = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("fout bij lezen van de breedte");
                            }
                        }
                    }
                    else
                    {
                        geel++;
                        if (geel > 10)
                        {
                            Pb_Bal1.Visible = false;
                        }

                        halfgeel++;
                        if (halfgeel > 10)
                        {
                            Pb_Bal9.Visible = false;
                        }
                    }




                    //blauw
                    if (data.Contains("sig: 6"))
                    {
                        int totalLength = data.Length;
                        if (totalLength > 50)
                        {

                            string sub = data.Substring(38, 4);
                            int result;
                            if (int.TryParse(sub, out result))
                            {
                                int Width = Convert.ToInt32(sub);
                                if (Width < 30)
                                {
                                    Pb_Bal10.Visible = true;
                                    halfblauw = 0;
                                }
                                else
                                {
                                    halfblauw++;
                                    if (halfblauw > 10)
                                    {
                                        Pb_Bal10.Visible = false;
                                    }
                                }
                                if (Width >= 30)
                                {
                                    Pb_Bal2.Visible = true;
                                    blauw = 0;
                                }
                                else
                                {
                                    blauw++;
                                    if (blauw > 10)
                                    {
                                        Pb_Bal2.Visible = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("fout bij lezen van de breedte");
                            }

                        }
                    }
                    else
                    {
                        blauw++;
                        if (blauw > 10)
                        {
                            Pb_Bal2.Visible = false;
                        }

                        halfblauw++;
                        if (halfblauw > 10)
                        {
                            Pb_Bal10.Visible = false;
                        }

                    }






                    //rood
                    if (data.Contains("sig: 2"))
                    {
                        int totalLength = data.Length;
                        if (totalLength > 50)
                        {
                            string sub = data.Substring(38, 4);
                            int result;
                            if (int.TryParse(sub, out result))
                            {
                                int Width = Convert.ToInt32(sub);
                                if (Width < 30)
                                {
                                    Pb_Bal11.Visible = true;
                                    halfrood = 0;
                                }
                                else
                                {
                                    halfrood++;
                                    if (halfrood > 10)
                                    {
                                        Pb_Bal11.Visible = false;
                                    }
                                }
                                if (Width >= 30)
                                {
                                    Pb_Bal3.Visible = true;
                                    rood = 0;
                                }
                                else
                                {
                                    rood++;
                                    if (rood > 10)
                                    {
                                        Pb_Bal3.Visible = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("fout bij lezen van de breedte");
                            }
                        }
                    }
                    else
                    {
                        rood++;
                        if (rood > 10)
                        {
                            Pb_Bal3.Visible = false;
                        }

                        halfrood++;
                        if (halfrood > 10)
                        {
                            Pb_Bal11.Visible = false;
                        }
                    }



                    //groen
                    if (data.Contains("sig: 4"))
                    {
                        int totalLength = data.Length;
                        if (totalLength > 50)
                        {
                            string sub = data.Substring(38, 4);
                            int result;
                            if (int.TryParse(sub, out result))
                            {
                                int Width = Convert.ToInt32(sub);
                                if (Width < 30)
                                {
                                    Pb_Bal14.Visible = true;
                                    halfgroen = 0;
                                }
                                else
                                {
                                    halfgroen++;
                                    if (halfgroen > 10)
                                    {
                                        Pb_Bal14.Visible = false;
                                    }
                                }
                                if (Width >= 30)
                                {
                                    Pb_Bal6.Visible = true;
                                    groen = 0;
                                }
                                else
                                {
                                    groen++;
                                    if (groen > 10)
                                    {
                                        Pb_Bal6.Visible = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("fout bij lezen van de breedte");
                            }

                        }
                    }
                    else
                    {
                        groen++;
                        if (groen > 10)
                        {
                            Pb_Bal6.Visible = false;
                        }

                        halfgroen++;
                        if (halfgroen > 10)
                        {
                            Pb_Bal14.Visible = false;
                        }
                    }




                    //paars
                    if (data.Contains("sig: 5"))
                    {
                        int totalLength = data.Length;
                        if (totalLength > 50)
                        {
                            string sub = data.Substring(38, 4);
                            int result;
                            if (int.TryParse(sub, out result))
                            {
                                int Width = Convert.ToInt32(sub);
                                if (Width < 30)
                                {
                                    Pb_Bal12.Visible = true;
                                    halfgroen = 0;
                                }
                                else
                                {
                                    halfpaars++;
                                    if (halfpaars > 10)
                                    {
                                        Pb_Bal12.Visible = false;
                                    }
                                }
                                if (Width >= 30)
                                {
                                    Pb_Bal4.Visible = true;
                                    paars = 0;
                                }
                                else
                                {
                                    paars++;
                                    if (paars > 10)
                                    {
                                        Pb_Bal4.Visible = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("fout bij lezen van de breedte");
                            }

                        }
                    }
                    else
                    {
                        paars++;
                        if (paars > 10)
                        {
                            Pb_Bal4.Visible = false;
                        }

                        halfpaars++;
                        if (halfpaars > 10)
                        {
                            Pb_Bal12.Visible = false;
                        }
                    }





                    //bordeaux
                    if (data.Contains("sig: 7"))
                    {
                        int totalLength = data.Length;
                        if (totalLength > 50)
                        {
                            string sub = data.Substring(38, 4);
                            int result;
                            if (int.TryParse(sub, out result))
                            {
                                int Width = Convert.ToInt32(sub);
                                if (Width < 30)
                                {
                                    Pb_Bal15.Visible = true;
                                    halfbordeaux = 0;
                                }
                                else
                                {
                                    halfbordeaux++;
                                    if (halfbordeaux > 10)
                                    {
                                        Pb_Bal15.Visible = false;
                                    }
                                }
                                if (Width >= 30)
                                {
                                    Pb_Bal7.Visible = true;
                                    bordeaux = 0;
                                }
                                else
                                {
                                    bordeaux++;
                                    if (bordeaux > 10)
                                    {
                                        Pb_Bal7.Visible = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("fout bij lezen van de breedte");
                            }

                        }
                    }
                    else
                    {
                        bordeaux++;
                        if (bordeaux > 10)
                        {
                            Pb_Bal7.Visible = false;
                        }

                        halfbordeaux++;
                        if (halfbordeaux > 10)
                        {
                            Pb_Bal15.Visible = false;
                        }
                    }








                    //oranje
                    if (data.Contains("sig: 3"))
                    {
                        int totalLength = data.Length;
                        if (totalLength > 50)
                        {
                            string sub = data.Substring(38, 4);
                            int result;
                            if (int.TryParse(sub, out result))
                            {
                                int Width = Convert.ToInt32(sub);
                                if (Width < 30)
                                {
                                    Pb_Bal13.Visible = true;
                                    halforanje = 0;
                                }
                                else
                                {
                                    halforanje++;
                                    if (halforanje > 10)
                                    {
                                        Pb_Bal13.Visible = false;
                                    }
                                }
                                if (Width >= 30)
                                {
                                    Pb_Bal5.Visible = true;
                                    oranje = 0;
                                }
                                else
                                {
                                    oranje++;
                                    if (oranje > 10)
                                    {
                                        Pb_Bal13.Visible = false;
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("fout bij lezen van de breedte");
                            }

                        }
                    }
                    else
                    {
                        oranje++;
                        if (oranje > 10)
                        {
                            Pb_Bal5.Visible = false;
                        }
                        halforanje++;
                        if (halforanje > 10)
                        {
                            Pb_Bal13.Visible = false;
                        }
                    }
                }
            }
            else
            {
                myport.Close();
            }
        
    }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }
    }
}
