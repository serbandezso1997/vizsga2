using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OceanicDesktop
{
    
    public partial class Form1 : Form
    {
        List<Berles> berlesLista = new List<Berles>();
        public Form1()
        {
            InitializeComponent();
            CsvBetoltese();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int dataId = berlesLista.Max(x => x.Id) +1;
            List<Berles> user = new List<Berles>();
            user.Add(new Berles
            {
                Id = dataId,
                YachtName = boatNameTxtBox.Text,
                Datum = dateTimePicker1.Value,
                Kategoria = comboBox1.Text,
                Osszeg = (int)numericUpDown1.Value,
                Megjegyzes = commentTxtBox.Text,

            });

            using (StreamWriter sw = new StreamWriter("yacht_koltsegek_2024.csv", append: true))
            {
                foreach (var b in user)
                {
                    sw.WriteLine($"{b.Id},{b.YachtName},{b.Datum:yyyy-MM-dd},{b.Kategoria},{b.Osszeg}");
                }
            }

            berlesLista.Add(new Berles {

                Id = dataId,
                YachtName = boatNameTxtBox.Text,
                Datum = dateTimePicker1.Value,
                Kategoria = comboBox1.Text,
                Osszeg = (int)numericUpDown1.Value,
                Megjegyzes = commentTxtBox.Text,
            });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = berlesLista;
            boatNameTxtBox.Text = string.Empty;
            commentTxtBox.Text = string.Empty;
            commentTxtBox.Text= string.Empty;



        }

        public void CsvBetoltese()
        {
            //List<Berles> berlesLista = new List<Berles>();
            var szoveg = File.ReadAllLines("yacht_koltsegek_2024.csv");

            for (int i = 1; i < szoveg.Length; i++)
            {
                var sor = szoveg[i].Split(';');

                berlesLista.Add(new Berles
                {
                    Id = int.Parse(sor[0]),
                    YachtName = sor[1],
                    Datum = DateTime.Parse(sor[2]),
                    Kategoria = sor[3],
                    Osszeg = int.Parse(sor[4]),
                    Megjegyzes = sor[5]  
                });
            }

            this.dataGridView1.DataSource = berlesLista;

            


        }


    }
    //id;yachtname;datum;kategoria;osszeg;megjegyzes
    public class Berles
    {

        public int Id { get; set; }
        public string YachtName { get; set; }
        public DateTime Datum { get; set; }
        public string Kategoria { get; set; }
        public int Osszeg { get; set; }
        public string Megjegyzes { get; set; }
    }
}
