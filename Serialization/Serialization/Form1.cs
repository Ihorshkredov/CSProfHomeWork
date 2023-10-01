using System.Xml.Serialization;

namespace Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are glad for you!!!", "choise YES");
        }

        private void btnNo_MouseEnter(object sender, EventArgs e)
        {

            Random rand = new Random();

            btnNo.Location = new Point(rand.Next(50, this.Width - 100), rand.Next(50, this.Height - 70));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream stream = new FileStream("ButtonNo.xml", FileMode.OpenOrCreate);
            var coordinates = new Cordinates(btnNo.Location.X, btnNo.Location.Y);

            XmlSerializer serializer = new XmlSerializer(typeof(Cordinates));
            serializer.Serialize(stream, coordinates);
            stream.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var stream = new FileStream("ButtonNo.xml", FileMode.Open);
                var serialazer = new XmlSerializer(typeof(Cordinates));

                Cordinates readcoordinates = (Cordinates)serialazer.Deserialize(stream);
                btnNo.Location = new Point(readcoordinates.X,readcoordinates.Y);
                stream.Close();
            }
            catch (FileNotFoundException)
            {

                btnNo.Location = new Point(480, 370);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}