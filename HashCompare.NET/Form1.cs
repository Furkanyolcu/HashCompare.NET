using System;
using System.Windows.Forms;

namespace HashingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            int[] randomNumbers = RandomGenerator.GenerateRandomNumbers(1000);

            listBoxRandomNumbers.Items.Clear();
            comboBoxNumbers.Items.Clear();
            foreach (var number in randomNumbers)
            {
                listBoxRandomNumbers.Items.Add(number);
                comboBoxNumbers.Items.Add(number);
            }

            GenericBuild[] algorithms =
            {
                new MyHashing(),
                new EischHashing(),
                new LichHashing(),
                new LischHashing(),
                new ReischHashing(),
                new BlischHashing(),
                new RelischHashing(),
                new BeischHashing()
            };

            dataGridViewResults.Rows.Clear(); 

            foreach (var algorithm in algorithms)
            {
                algorithm.RunHashing(randomNumbers); 

                dataGridViewResults.Rows.Add(
                    algorithm.GetType().Name, 
                    algorithm.ElapsedTime.TotalMilliseconds, 
                    algorithm.StepCount, 
                    algorithm.CollisionCount 
                );
            }

            MessageBox.Show("Algoritmalar çalıştırıldı ve sonuçlar gösteriliyor.");
        }

        private void RunSingleAlgorithm(GenericBuild algorithm)
        {
            int[] randomNumbers = RandomGenerator.GenerateRandomNumbers(1000);
            listBoxRandomNumbers.Items.Clear();
            foreach (var number in randomNumbers)
            {
                listBoxRandomNumbers.Items.Add(number);
            }
                       
            dataGridViewResults.Rows.Clear(); 

            algorithm.RunHashing(randomNumbers);

            dataGridViewResults.Rows.Add(
                algorithm.GetType().Name,
                algorithm.ElapsedTime.TotalMilliseconds,
                algorithm.StepCount,
                algorithm.CollisionCount 
            );

            MessageBox.Show($"{algorithm.GetType().Name} algoritması çalıştırıldı.");
        }

        private void Performans_karsilastir_Click(object sender, EventArgs e)
        { 
            dataGridViewResults.Sort(dataGridViewResults.Columns[1], System.ComponentModel.ListSortDirection.Ascending);

            MessageBox.Show("Algoritmalar zamanlarına göre sıralandı.");
        }



        private void buttonMyHashing_Click(object sender, EventArgs e)
        {
            RunSingleAlgorithm(new MyHashing());
        }

        private void buttonEischHashing_Click(object sender, EventArgs e)
        {
            RunSingleAlgorithm(new EischHashing());
        }

        private void buttonLichHashing_Click(object sender, EventArgs e)
        {
            RunSingleAlgorithm(new LichHashing());
        }

        private void buttonLischHashing_Click(object sender, EventArgs e)
        {
            RunSingleAlgorithm(new LischHashing());
        }

        private void buttonReischHashing_Click(object sender, EventArgs e)
        {
            RunSingleAlgorithm(new ReischHashing());
        }

        private void buttonBlischHashing_Click(object sender, EventArgs e)
        {
            RunSingleAlgorithm(new BlischHashing());
        }

        private void buttonRelischHashing_Click(object sender, EventArgs e)
        {
            RunSingleAlgorithm(new RelischHashing());
        }

        private void buttonBeischHashing_Click(object sender, EventArgs e)
        {
            RunSingleAlgorithm(new BeischHashing());
        }

      
    }
}
