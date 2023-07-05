using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
namespace WindowsFormsApp3
{
    public partial class LCGform : Form
    {
        public LCGform()
        {
            InitializeComponent();
        }
        int multiplier, seed, increment, modulus, NunOfIter;
        bool FormIsUsed = false;
        Generator LCGen;
        private void SetLabelsFont()
        {
            IntroLabel.Font = new Font("Calibri", 13, FontStyle.Bold);
            Multiplier.Font = new Font("Calibri", 10, FontStyle.Bold);
            Seed.Font = new Font("Calibri", 10, FontStyle.Bold);
            CycleLength.Font = new Font("Calibri", 10, FontStyle.Bold);
            CycleLengthVal.Font = new Font("Calibri", 10, FontStyle.Bold);
            NumOfIteration.Font = new Font("Calibri", 10, FontStyle.Bold);
            NunOfIterVal.Font = new Font("Calibri", 10, FontStyle.Bold);
            Increment.Font = new Font("Calibri", 10, FontStyle.Bold);
            Modulus.Font = new Font("Calibri", 10, FontStyle.Bold);
            GenerateBtn.Font = new Font("Calibri", 12, FontStyle.Bold);
            MethodName.Font = new Font("Calibri", 10, FontStyle.Bold);
        }
        private void ResetFormItems()
        {
            MethodName.Text = "Method Name";
            CycleLength.Text = "Cycle Length";
            CycleLengthVal.Text = SeedVal.Text = MultiplierVal.Text = IncrementVal.Text = ModulusVal.Text = NunOfIterVal.Text = String.Empty;
            dataGridView1.DataSource = null;
            dataGridView1.Dock = DockStyle.Fill;
            Controls.Add(dataGridView1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}
        private void LCG_Load(object sender, EventArgs e)
        {
            SetLabelsFont();
        }
        private void IncrementVal_TextChanged(object sender, EventArgs e) { }
        private void NumOfIteration_Click(object sender, EventArgs e) { }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ResetFormItems();
        }

        private void NunOfIterVal_TextChanged(object sender, EventArgs e) { }
        private void IntroLabel_Click(object sender, EventArgs e) { }
        private void Multiplier_Click(object sender, EventArgs e) { }


        private void GenerateBtn_Click(object sender, EventArgs e)
        {

            if (FormIsUsed) // delete Info 
            {
                ResetFormItems();
                FormIsUsed = false;
            }
            try
            {
                if (SeedVal.Text != "" && MultiplierVal.Text != "" && IncrementVal.Text != "" && ModulusVal.Text != "")
                {
                    FormIsUsed = true;
                    increment = int.Parse(IncrementVal.Text);
                    multiplier = int.Parse(MultiplierVal.Text);
                    seed = int.Parse(SeedVal.Text);
                    modulus = int.Parse(ModulusVal.Text);
                    NunOfIter = int.Parse(NunOfIterVal.Text);
                    LCGen = new Generator(multiplier, seed, increment, modulus, NunOfIter);
                    LCGen.RunLCG();
                    CycleLengthVal.Text = LCGen.CycleLength.ToString();
                    // Change texts according to the case 
                    // Method Name
                    if (increment == 0)
                        MethodName.Text = "Multiplicative Congruential Method";
                    else
                        MethodName.Text = "Mixed Congruential Method";
                    // if It one of the scenarios or not
                    if (!LCGen.LongestLengthIsFound)
                        CycleLength.Text = "Current Cycle Length";
                    else
                        CycleLength.Text = "Longest Cycle Length";
                    CycleLengthVal.Text = LCGen.CycleLength.ToString();

                    dataGridView1.DataSource = LCGen.linearCongruentials;
                    dataGridView1.Dock = DockStyle.Fill;
                    Controls.Add(dataGridView1);
                    this.BackgroundImage = Properties.Resources.RandNumsImg;
                }
                else
                {
                    MessageBox.Show("Please enter the required data", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Data entry ERROR");
            }
        }
    }
}
