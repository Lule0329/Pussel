using Pussel.Properties;

namespace Pussel
{
    public partial class Form1 : Form
    {
        // Alla Arrays
        Image[] imageFirst = { Resources.krona_row_1_column_1, Resources.Taina__1_, Resources.zach_row_1_column_1, Resources.Oliver__1_};
        Image[] imageSecond = { Resources.krona_row_1_column_2, Resources.Taina__2_, Resources.zach_row_1_column_2, Resources.Oliver__2_};
        Image[] imageThird = { Resources.krona_row_2_column_1, Resources.Taina__3_, Resources.zach_row_2_column_1, Resources.Oliver__3_};
        Image[] imageFourth = { Resources.krona_row_2_column_2, Resources.Taina__4_, Resources.zach_row_2_column_2, Resources.Oliver__4_ };

        // Variabler för varje array
        int first = 0;
        int second = 1;
        int third = 2;
        int fourth = 3;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sätter alla pictureboxes till olika bilder i början
            pictureBox1.Image = imageFirst[first];
            pictureBox2.Image = imageSecond[second];
            pictureBox3.Image = imageThird[third];
            pictureBox4.Image = imageFourth[fourth];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Byter till nästa bild i Arrayen
            first = (first + 1) % imageFirst.Length;
            pictureBox1.Image = imageFirst[first];

            // kollar om alla pictureboxes har rätt bild i sig
            if (fourth == third && third == second && second == first)
            {
                MessageBox.Show("Correct!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Byter till nästa bild i Arrayen
            second = (second + 1) % imageSecond.Length;
            pictureBox2.Image = imageSecond[second];

            // kollar om alla pictureboxes har rätt bild i sig
            if (fourth == third && third == second && second == first)
            {
                MessageBox.Show("Correct!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Byter till nästa bild i Arrayen
            third = (third + 1) % imageThird.Length;
            pictureBox3.Image = imageThird[third];

            // kollar om alla pictureboxes har rätt bild i sig
            if (fourth == third && third == second && second == first)
            {
                MessageBox.Show("Correct!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Byter till nästa bild i Arrayen
            fourth = (fourth + 1) % imageFourth.Length;
            pictureBox4.Image = imageFourth[fourth];

            // kollar om alla pictureboxes har rätt bild i sig
            if (fourth == third && third == second && second == first)
            {
                MessageBox.Show("Correct!");
            }
        }
    }
}
