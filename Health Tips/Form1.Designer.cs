/* Program Displays Few Health tips in two screens.
 * Wait for 3 secs. to see more health tips on next screen.
 * Program intentionally created in 32 lines.
 * Author-: Awdesh Sharma
 * Date-: 09/26/2014
 */
namespace HealthTips
{   partial class Form1  {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer myTimer;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 97);
            this.label2.Size = new System.Drawing.Size(803, 117);
            this.label2.Text = "1.) An Average Person walks 10,000 steps a day!\n2.) You walk 100 steps per minute!\n3.) Drink Your Milk!\n4.) Avoid large meals before bedtime.";
            this.myTimer.Enabled = true;
            this.myTimer.Interval = 3000;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            this.Controls.Add(this.label2);
            this.Text = "Daily 8 Health Living Tips.";
        }
        /// <summary>
        /// Event handler to update label text and stop the timer.
        /// </summary>
        /// <param name="sender">Timer event.</param>
        /// <param name="eArgs"></param>
        public void myTimer_Tick(object sender, System.EventArgs eArgs)
        { if (sender == myTimer) {
            label2.Text = "1.) Eat Your Breakfast!\n2.) Take good 8-9 hrs. Sleep.!\n3.) Remember your Vaccine!\n4.) Exercise, Dance or play some outdoor game.";
                myTimer.Stop(); }}
}}