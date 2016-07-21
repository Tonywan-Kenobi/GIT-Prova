using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using System.Globalization;


public partial class vinci : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, System.EventArgs e)
    {
        LabelAllegato1.HRef = "";
        if (FileUpload1.HasFile)
        {
            LabelMessaggi.Style.Add("display", "none");

            string fileCaricato = FileUpload1.FileName;
            if (!Directory.Exists(Server.MapPath("vinci/")))
                Directory.CreateDirectory(Server.MapPath("vinci/"));

            if (File.Exists(Server.MapPath("vinci/") + FileUpload1.FileName))
                File.Delete(Server.MapPath("vinci/") + FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath("vinci/") + FileUpload1.FileName);

            /*file destinazione*/
            string nomefile = Server.MapPath("vinci/ESPORTAZIONE_VINCI_" + DateTime.Today.ToString("MM") + ".TXT");

            if (File.Exists(Server.MapPath("vinci/ESPORTAZIONE_VINCI_" + DateTime.Today.ToString("MM") + ".TXT")))
                File.Delete(Server.MapPath("vinci/ESPORTAZIONE_VINCI_" + DateTime.Today.ToString("MM") + ".TXT"));

            StreamWriter sw = new StreamWriter(nomefile, false, System.Text.Encoding.Default);

            /* apro il file e itero*/
            StreamReader sr = new StreamReader(Server.MapPath("vinci/") + FileUpload1.FileName);


            string sql = "";
            String line = "";
            String intestazione = "";
            string mese = "";
            string anno = "";
            string campo1 = "";
            string campo2 = "";
            string campo3 = "";
            string campo4 = "";
            string campo5 = "";
            string campo6 = "";
            string campo7 = "";
            string campo8 = "";
            string campo9 = "";
            string campo10 = "";
            string campo11 = "";
            string campo12 = "";
            string campo13 = "";
            string campo14 = "";
            string campo15 = "";
            string campo16 = "";
            string campo17 = "";
            string campo18 = "";
            string campo19 = "";
            string campo20 = "";
            string campo21 = "";
            string campo22 = "";
            string campo23 = "";
            string campo24 = "";
            string campo25 = "";
            string campo26 = "";
            string campo27 = "";
            string campo28 = "";
            string campo29 = "";
            string campo30 = "";
            string campo31 = "";
            string campo32 = "";
            string campo33 = "";
            string campo34 = "";
            string campo35 = "";
            string campo36 = "";
            string campo37 = "";
            string campo38 = "";
            string cod_imp = "";
            string sub_imp = "";
            int cont = 0;
            double tot_mandati = 0;
            double tot_reversali = 0;
            string finale = "";
            string record_finale = "";

            while (sr.Peek() >= 0)
            {
                finale = "";
                cont = cont + 1;
                line = sr.ReadLine();

                if (line[0].CompareTo('A') == 0)
                {
                    intestazione = line;
                    mese = intestazione.Substring(8, 2);

                    anno = intestazione.Substring(10, 4);
                }
                else
                {
                    campo1 = "         0 ";
                    campo2 = " " + anno + " ";
                    campo3 = " " + line[0].ToString() + " ";
                    campo4 = " " + mese + " ";
                    campo5 = " " + "00" + " ";
                    campo6 = " " + "S" + " ";
                    campo7 = " " + "00" + " ";
                    campo8 = " " + line.Substring(298, 6) + " ";
                    campo9 = "                                                              ";//62 vuoti
                    campo10 = "    ";//4 vuoti
                    campo11 = "0000 ";
                    campo12 = "                                                                                                                          "; //122 vuoti
                    campo13 = " " + "00000" + " ";
                    campo14 = " 000" + line.Substring(1, 6) + " ";
                    campo15 = " 0000" + line.Substring(7, 2) + " ";
                    campo16 = " " + line.Substring(15, 4) + " ";
                    campo17 = "              "; // 14 spazi
                    //campo18 = "" + line.Substring(9, 1) + " ";
                    campo18 = "D ";
                    cod_imp = "";
                    if (line[0].CompareTo('E') == 0)
                        cod_imp = " " + "A." + line.Substring(10, 5) + "   ";
                    else if (line[0].CompareTo('U') == 0)
                        cod_imp = " " + "I." + line.Substring(11, 4) + "    ";
                    else
                        cod_imp = " " + "  " + "     " + "    ";

                    campo19 = cod_imp;

                    campo20 = " " + line.Substring(20, 4) + " ";  // controlla di 5 caratteri ho preso i 4 più a dx m // inizialmente era in posizione 23
                    campo21 = " " + line.Substring(15, 4) + " ";  // come campo16
                    campo22 = "         ";  // 9 buoti
                    campo23 = "  "; // 2 vuoti
                    campo24 = "  "; // 2 vuoti
                    campo25 = line.Substring(286, 9) + " ";


                    if (campo3.Trim() == "E")
                        tot_mandati = tot_mandati + Convert.ToDouble(line.Substring(286, 9));
                    if (campo3.Trim() == "U")
                        tot_reversali = tot_reversali + Convert.ToDouble(line.Substring(286, 9));

                    campo26 = "            "; //12 vuoti
                    campo27 = "  ";//2 vuote
                    campo28 = " "; //1vuoto
                    campo29 = " " + "000" + " ";
                    campo30 = " " + "000" + " ";
                    campo31 = " " + "000" + " ";
                    campo32 = " " + "0000000" + " ";
                    campo33 = "0" + " ";
                    campo34 = "  "; // 2 vuoti
                    campo35 = " " + line.Substring(555, 4) + " "; // controlla
                    campo36 = " " + "0" + " ";
                    campo37 = " " + "0" + " ";
                    campo38 = " " + "0" + " ";

                    record_finale = campo1 + "|" + campo2 + "|" + campo3 + "|" + campo4 + "|" + campo5 + "|";
                    record_finale = record_finale + campo6 + "|" + campo7 + "|" + campo8 + "|" + campo9 + "|" + campo10 + "|" + campo11 + "|";
                    record_finale = record_finale + campo12 + "|" + campo13 + "|" + campo14 + "|" + campo15 + "|" + campo16 + "|" + campo17 + "|";
                    record_finale = record_finale + campo18 + "|" + campo19 + "|" + campo20 + "|" + campo21 + "|" + campo22 + "|" + campo23 + "|";
                    record_finale = record_finale + campo24 + "|" + campo25 + "|" + campo26 + "|" + campo27 + "|" + campo28 + "|" + campo29 + "|";
                    record_finale = record_finale + campo30 + "|" + campo31 + "|" + campo32 + "|" + campo33 + "|" + campo34 + "|" + campo35 + "|";
                    record_finale = record_finale + campo36 + "|" + campo37 + "|" + campo38 + "|";

                    sw.WriteLine(record_finale);
                }
            }

            sr.Close();
            sw.Close();

            tot_mandati = tot_mandati / 100;
            tot_reversali = tot_reversali / 100;


            label.Text = "Sono stati processati " + cont.ToString() + "utenti";
            mandati.Text = "Totale mandati: " + tot_mandati.ToString() + " €";
            reversali.Text = "Totale reversali: " + tot_reversali.ToString() + " €";

            LabelAllegato1.HRef = ("vinci/ESPORTAZIONE_VINCI_" + DateTime.Today.ToString("MM") + ".TXT");
            LabelAllegato1.Style.Add("display", "inline-block");
        }
        else
        {
            LabelMessaggi.Style.Add("display", "inline-block");
            //LabelMessaggi.Text = "Selezionare prima il file da salvare.";
        }
    }
}