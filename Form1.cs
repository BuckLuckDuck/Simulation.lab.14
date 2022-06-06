using System;
using System.Drawing;
using System.Windows.Forms;

namespace Simulation.lab._14
{
    public partial class Form1 : Form
    {

        systemTemp bank = new systemTemp();
        humanGenerator generator;
        le_operatori oper_une;
        le_operatori oper_deux;
        le_operatori oper_trois;

        public Form1()
        {
            InitializeComponent();
            oper_une = new le_operatori(btn_oper_1);
            oper_deux = new le_operatori(btn_oper_2);
            oper_trois = new le_operatori(btn_oper_3);
            generator = new humanGenerator();
            // bank = new systemTemp();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Visible = false;
            timer1.Start();
            btn_stop.Visible = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_stop.Visible = false;
            timer1.Stop();
            btn_start.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_ppl_count.Text = Convert.ToString(bank.queue);

            generator.time_cheker(bank, (int)nud_avg_new_ppl.Value);
            oper_une.time_cheker();
            oper_deux.time_cheker();
            oper_trois.time_cheker();

            if (oper_une.isFree && bank.queue != 0)
            {
                oper_une.notFree(bank, (int)nud_avg_service_time.Value);
                bank.DeleteHumanFromQueue();
                lbl_ppl_count.Text = Convert.ToString(bank.queue);
            }
            if (oper_deux.isFree && bank.queue != 0)
            {
                oper_deux.notFree(bank, (int)nud_avg_service_time.Value);
                bank.DeleteHumanFromQueue();
                lbl_ppl_count.Text = Convert.ToString(bank.queue);
            }
            if (oper_trois.isFree && bank.queue != 0)
            {
                oper_trois.notFree(bank, (int)nud_avg_service_time.Value);
                bank.DeleteHumanFromQueue();
                lbl_ppl_count.Text = Convert.ToString(bank.queue);
            }




            generator.time_new_client += -1;
            oper_une.service_time += -1;
            oper_deux.service_time += -1;
            oper_trois.service_time += -1;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    // 1. Генератор создает число, через какое время появиться новый человек
    // 2. Генератор создает человека
    // 3. Если есть свободной опер
    // 4. Клиент отрправляется к оператору => оператор становиться занятым
    // 5. Если фрии опер нет, то куе + 1

    public class humanGenerator
    {
        public int time_new_client;

        void GenerateHuman(systemTemp obj)
        {
            obj.AddHumanToQueue();
        }

        public void time_cheker(systemTemp obj, int average)
        {
            if (time_new_client <= 0)
            {
                GenerateHuman(obj);
                time_new_client = obj.getTime(average);
            }
        }

        public humanGenerator()
        {
            time_new_client = 0;
        }
    }

    public class systemTemp
    {

        public int queue = 5;

        public void AddHumanToQueue()
        {
            queue = queue + 1;

        }

        public void DeleteHumanFromQueue()
        {
            queue = queue - 1;
        }

        public int getTime(int average)
        {
            double sum = 0;
            int m = 1;

            Random rnd = new Random();

            sum += Math.Log(rnd.NextDouble());
            while (sum >= -average)
            {
                m++;
                sum += Math.Log(rnd.NextDouble());
            }
            return m;
        }
    }

    public class le_operatori
    {
        public Button box;
        public bool isFree;
        public int service_time;

        public le_operatori(Button btn_le_opera)
        {
            isFree = true;
            box = btn_le_opera;
            service_time = 0;
            box.BackColor = Color.Lime;
        }

        public void time_cheker()
        {
            if (service_time <= 0)
            {
                isFree = true;
                box.BackColor = Color.Lime;
            }
        }

        public void notFree(systemTemp obj, int avg)
        {
            service_time = obj.getTime(avg);
            isFree = false;
            box.BackColor = Color.IndianRed;
        }
    }
}