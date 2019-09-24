using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Runtime.InteropServices;

namespace Section_cc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Control[] matches;
            for (int i = 1; i <= (map_dimension * map_dimension); i++)
            {
                matches = this.Controls.Find("pictureBox" + i.ToString(), true);
                if (matches.Length > 0 && matches[0] is PictureBox)
                {
                    pictureBoxes.Add((PictureBox)matches[0]);
                }
            }
            display_timer.Tick += new EventHandler(display_timer_Tick);
            display_timer.Start();
        }

        int position_player_1 = 1, position_player_2 = 25, map_dimension = 5, move = 0, turn = 2, walk, move_max = 4, WIN, vertival_move, horizontal_move,
            w_distance_U, w_distance_D, w_distance_R, w_distance_L, p_distance_U, p_distance_D, p_distance_R, p_distance_L, single_player = 0, timer_bar = 100,
            maxValue, maxIndex;

        int[] sum_distance = new int[4];

        List<PictureBox> pictureBoxes = new List<PictureBox>();

        Random rnd = new Random();


        private void keydown(object sender, KeyEventArgs e)
        {
            if (turn == 1)
            {
                if (e.KeyCode == Keys.W)
                {
                    Thread thread1 = new Thread(new ThreadStart(move_thread));
                    thread1.Start();
                    walk = -map_dimension;
                }
                if (e.KeyCode == Keys.A)
                {
                    Thread thread1 = new Thread(new ThreadStart(move_thread));
                    thread1.Start();
                    walk = -1;
                }
                if (e.KeyCode == Keys.S)
                {
                    Thread thread1 = new Thread(new ThreadStart(move_thread));
                    thread1.Start();
                    walk = map_dimension;
                }
                if (e.KeyCode == Keys.D)
                {
                    Thread thread1 = new Thread(new ThreadStart(move_thread));
                    thread1.Start();
                    walk = 1;
                }
            }
            else if (turn == 2)
            {
                if (e.KeyCode == Keys.P)
                {
                    Thread thread1 = new Thread(new ThreadStart(move_thread));
                    thread1.Start();
                    walk = -map_dimension;
                }
                if (e.KeyCode == Keys.L)
                {
                    Thread thread1 = new Thread(new ThreadStart(move_thread));
                    thread1.Start();
                    walk = -1;
                }
                if (e.KeyCode == Keys.OemSemicolon)
                {
                    Thread thread1 = new Thread(new ThreadStart(move_thread));
                    thread1.Start();
                    walk = map_dimension;
                }
                if (e.KeyCode == Keys.OemQuotes)
                {
                    Thread thread1 = new Thread(new ThreadStart(move_thread));
                    thread1.Start();
                    walk = 1;
                }
            }
        }

        private void move_thread()
        {
            if (turn == 1)
            {
                if (position_player_1 + walk > 0 & position_player_1 + walk <= (map_dimension * map_dimension))
                {
                    if (position_player_1 % map_dimension == 0 & walk == 1)
                    {
                        position_player_1 -= walk;
                    }

                    if (position_player_1 % map_dimension == 1 & walk == -1)
                    {
                        position_player_1 -= walk;
                    }

                    position_player_1 += walk;

                    move--;
                    if (move == 0)
                    {
                        if (position_player_1 == position_player_2)
                        {
                            WIN = 1;

                            timer_com_walk.Tick -= new EventHandler(timer_com_walk_Tick);
                            timer_com_walk.Stop();

                            player_walk_timer.Tick -= new EventHandler(player_walk_timer_Tick);
                            player_walk_timer.Stop();
                        }
                        else
                        {
                            if (single_player == 1)
                            {
                                turn = 3;
                                move = rnd.Next(1, move_max);
                            }
                            else
                            {
                                turn = 2;
                                move = rnd.Next(1, move_max);
                            }
                            
                        }
                    }
                }
            }

            else if (turn == 2)
            {
                if (position_player_2 + walk > 0 & position_player_2 + walk <= (map_dimension * map_dimension))
                {
                    if (position_player_2 % map_dimension == 0 & walk == 1)
                    {
                        position_player_2 -= walk;
                    }

                    if (position_player_2 % map_dimension == 1 & walk == -1)
                    {
                        position_player_2 -= walk;
                    }

                    position_player_2 += walk;
                    move--;
                    if (move == 0)
                    {
                        if (position_player_1 == position_player_2)
                        {
                            WIN = 1;

                            player_walk_timer.Tick -= new EventHandler(player_walk_timer_Tick);
                            player_walk_timer.Stop();
                        }
                        else
                        {
                            turn = 1;
                            move = rnd.Next(1, move_max);
                        }
                    }
                }
            }

            timer_bar = 100;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            turn = rnd.Next(1, 2);
            move = rnd.Next(1, move_max);
            position_player_1 = 1;
            position_player_2 = 25;
            WIN = 0;

            button1.Enabled = false;
            button2.Enabled = false;

            player_walk_timer.Tick += new EventHandler(player_walk_timer_Tick);
            player_walk_timer.Start();

            single_player = 0;

            textBox1.Text = "";
            textBox1.Focus();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            turn = 1;
            move = rnd.Next(1, move_max);
            position_player_1 = 1;
            position_player_2 = 25;
            WIN = 0;

            button1.Enabled = false;
            button2.Enabled = false;

            timer_com_walk.Interval = 1500;
            timer_com_walk.Tick += new EventHandler(timer_com_walk_Tick);
            timer_com_walk.Start();

            player_walk_timer.Tick += new EventHandler(player_walk_timer_Tick);
            player_walk_timer.Start();

            single_player = 1;

            textBox1.Text = "";
            textBox1.Focus();
        }

        private void display_timer_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= (map_dimension * map_dimension); i++)
            {
                pictureBoxes[i - 1].BackColor = Color.White;
            }

            pictureBoxes[position_player_1 - 1].BackColor = Color.Red;
            pictureBoxes[position_player_2 - 1].BackColor = Color.Green;

            label1.Text = "Move left: " + move.ToString();

            if (turn == 1)
            {
                label2.Text = "Red turn";
                label2.ForeColor = Color.Red;
                if (WIN == 1)
                {
                    label2.Text = "Player 1 WIN";
                    pictureBoxes[position_player_1 - 1].BackColor = Color.Goldenrod;
                    button1.Visible = true;
                    button2.Visible = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
            }
            if (turn == 2)
            {
                label2.Text = "Green turn";
                label2.ForeColor = Color.Green;
                if (WIN == 1)
                {
                    label2.Text = "Player 2 WIN";
                    pictureBoxes[position_player_1 - 1].BackColor = Color.Goldenrod;
                    button1.Visible = true;
                    button2.Visible = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
            }

            if (turn == 3)
            {
                label2.Text = "Computer turn";
                label2.ForeColor = Color.Purple;
                if (WIN == 1)
                {
                    label2.Text = "Computer WIN";
                    pictureBoxes[position_player_1 - 1].BackColor = Color.LightPink;
                    button1.Visible = true;
                    button2.Visible = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
            }
        }


        private void timer_com_walk_Tick(object sender, EventArgs e)
        {
            if (turn == 3)
            {
                horizontal_move = (Math.Abs((position_player_1 % map_dimension) - (position_player_2 % map_dimension)));
                vertival_move = (Math.Abs((position_player_1 / map_dimension) - (position_player_2 / map_dimension)));

                if (horizontal_move + vertival_move == move)
                {
                    if (position_player_1 > position_player_2)
                    {
                        if (vertival_move != 0)
                        {
                            position_player_2 += map_dimension;
                            vertival_move--;
                            move--;
                        }
                        else if (horizontal_move != 0)
                        {
                            if (position_player_2 % map_dimension == 0)
                            {
                                position_player_2--;
                                horizontal_move--;
                                move--;
                            }
                            else
                            {
                                position_player_2++;
                                horizontal_move--;
                                move--;
                            }
                        }
                    }

                    else if (position_player_1 < position_player_2)
                    {
                        if (vertival_move != 0)
                        {
                            position_player_2 -= map_dimension;
                            vertival_move--;
                            move--;
                        }
                        else if (horizontal_move != 0)
                        {
                            if (position_player_2 % map_dimension == 1)
                            {
                                position_player_2++;
                                horizontal_move--;
                                move--;
                            }
                            else
                            {
                                position_player_2--;
                                horizontal_move--;
                                move--;
                            }
                        }
                    }
                }
                else
                {
                    w_distance_U = (position_player_2 / map_dimension) - 1;
                    w_distance_D = map_dimension - (position_player_2 / map_dimension);

                    if (position_player_2 % map_dimension == 0)
                    {
                        w_distance_L = 4;
                    }
                    else
                    {
                        w_distance_L = position_player_2 % map_dimension - 1;
                    }

                    w_distance_R = (map_dimension - w_distance_L) - 1;

                    p_distance_U = (Math.Abs(position_player_1 - (position_player_2 -= map_dimension)) % map_dimension) + (Math.Abs(position_player_1 - (position_player_2 -= map_dimension)) / map_dimension);
                    p_distance_D = (Math.Abs(position_player_1 - (position_player_2 += map_dimension)) % map_dimension) + (Math.Abs(position_player_1 - (position_player_2 += map_dimension)) / map_dimension);
                    p_distance_L = (Math.Abs(position_player_1 - (position_player_2 - 1)) % map_dimension) + (Math.Abs(position_player_1 - (position_player_2 - 1)) / map_dimension);
                    p_distance_R = (Math.Abs(position_player_1 - (position_player_2 + 1)) % map_dimension) + (Math.Abs(position_player_1 - (position_player_2 + 1)) / map_dimension);

                    if ((position_player_2 -= map_dimension) > 0) { sum_distance[0] = w_distance_U + p_distance_U; }
                    else { sum_distance[0] = 0; }

                    if ((position_player_2 += map_dimension) < 25) { sum_distance[1] = w_distance_D = p_distance_D; }
                    else { sum_distance[1] = 0; }

                    if (position_player_2 % map_dimension != 1) { sum_distance[2] = w_distance_L + p_distance_L; }
                    else { sum_distance[2] = 0; }

                    if (position_player_2 % map_dimension != 0) { sum_distance[3] = w_distance_R + p_distance_R; }
                    else { sum_distance[3] = 0; }

                    maxValue = sum_distance.Max();
                    maxIndex = sum_distance.ToList().IndexOf(maxValue);

                    if (maxIndex == 0) { position_player_2 -= map_dimension; }
                    if (maxIndex == 1) { position_player_2 += map_dimension; }
                    if (maxIndex == 2) { position_player_2--; }
                    if (maxIndex == 3) { position_player_2++; }

                    move--;
                }

                if (move == 0)
                {
                    if (position_player_1 == position_player_2)
                    {
                        WIN = 1;

                        player_walk_timer.Tick -= new EventHandler(player_walk_timer_Tick);
                        player_walk_timer.Stop();

                        timer_com_walk.Tick -= new EventHandler(timer_com_walk_Tick);
                        timer_com_walk.Stop();
                    }
                    else
                    {
                        turn = 1;
                        move = rnd.Next(1, move_max);
                    }
                   
                }
                timer_bar = 100;
            }
        }

        private void player_walk_timer_Tick(object sender, EventArgs e)
        {
            timer_bar --;
            timer_walk_progressBar.Value = timer_bar;

            if (timer_bar == 0)
            {
                timer_bar = 100;
                move--;

                if (move == 0)
                {
                    if (turn == 1)
                    {
                        if (single_player == 1)
                        {
                            turn = 3;
                            move = rnd.Next(1, move_max);
                        }
                        else
                        {
                            turn = 2;
                            move = rnd.Next(1, move_max);
                        }
                    }
                    else
                    {
                        turn = 1;
                        move = rnd.Next(1, move_max);
                    }

                }
            }
            
        }


    }
}
