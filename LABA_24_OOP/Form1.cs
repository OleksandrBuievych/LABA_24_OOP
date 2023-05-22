using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LABA_24_OOP
{
    public partial class Form1 : Form
    {
        private bool isEncryptionRunning;
        private Thread encryptionThread;
        private bool isHashingRunning;
        private Thread hashingThread;
        private bool isGenerating;
        private Thread generationThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartM1_Click(object sender, EventArgs e)
        {
            if (!isEncryptionRunning)
            {
                isEncryptionRunning = true;
                StartM1.Enabled = false;
                StopM1.Enabled = true;

                // Створюємо новий потік для шифрування
                encryptionThread = new Thread(EncryptNumbers);
                encryptionThread.Start();
            }
        }

        private void EncryptNumbers()
        {
            int number = 1;

            while (isEncryptionRunning)
            {
                // Шифруємо число з використанням алгоритму FEAL
                int encryptedNumber = EncryptUsingFEAL(number);

                // Виводимо зашифроване число у текстовому полі
                AddEncryptedNumberToTextBox(encryptedNumber);

                // Збільшуємо число для наступного шифрування
                number = (number % 10) + 1;

                // Затримка перед наступною ітерацією шифрування
                Thread.Sleep(1000); // 1 секунда
            }
        }

        private int EncryptUsingFEAL(int number)
        {
            // Тут виконується шифрування числа number методом FEAL
            // додаємо 1 до числа
            int encryptedNumber = number + 1;

            // Повертаємо зашифроване число
            return encryptedNumber;
        }

        private void AddEncryptedNumberToTextBox(int number)
        {
            if (txtEncryptedNumbers.InvokeRequired)
            {
                txtEncryptedNumbers.Invoke(new MethodInvoker(delegate
                {
                    txtEncryptedNumbers.AppendText(number.ToString() + Environment.NewLine);
                }));
            }
            else
            {
                txtEncryptedNumbers.AppendText(number.ToString() + Environment.NewLine);
            }
        }

        private void StopM1_Click(object sender, EventArgs e)
        {
            if (isEncryptionRunning)
            {
                isEncryptionRunning = false;
                StartM1.Enabled = true;
                StopM1.Enabled = false;

                // Зупиняємо потік шифрування
                encryptionThread.Abort();
            }

        }

        private void StartM2_Click(object sender, EventArgs e)
        {
            if (!isHashingRunning)
            {
                isHashingRunning = true;
                StartM2.Enabled = false;
                StopM2.Enabled = true;

                // Створюємо новий потік для хешування
                hashingThread = new Thread(HashNumbers);
                hashingThread.Start();
            }
        }

        private void HashNumbers()
        {
            using (MD5 md2 = MD5.Create())
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (!isHashingRunning)
                        return;

                    // Хешуємо число від 1 до 10
                    byte[] hash = md2.ComputeHash(Encoding.UTF8.GetBytes(i.ToString()));

                    // Перетворюємо хеш в рядок для відображення
                    string hashString = BitConverter.ToString(hash).Replace("-", "");

                    // Виводимо хеш у текстовому полі
                    AddHashToTextBox(hashString);

                    // Затримка перед наступною ітерацією хешування
                    Thread.Sleep(1000); // 1 секунда
                }
            }
        }

        private void AddHashToTextBox(string hash)
        {
            try
            {
                if (txtHash.InvokeRequired)
                {
                    txtHash.Invoke(new MethodInvoker(delegate
                    {
                        txtHash.AppendText(hash + Environment.NewLine);
                    }));
                }
                else
                {
                    txtHash.AppendText(hash + Environment.NewLine);
                }
            }
            catch (Exception stopmetod) { MessageBox.Show("Зупиніть усі методи!"); StopM2.PerformClick(); }
        }
        private void StopM2_Click(object sender, EventArgs e)
        {
            if (isHashingRunning)
            {
                isHashingRunning = false;
                StartM2.Enabled = true;
                StopM2.Enabled = false;

                // Зупиняємо потік хешування
                hashingThread.Abort();
            }
        }

        private void StartM3_Click(object sender, EventArgs e)
        {
            if (!isGenerating)
            {
                isGenerating = true;
                StartM3.Enabled = false;
                StopM3.Enabled = true;

                // Створюємо новий потік для генерації чисел
                generationThread = new Thread(GenerateNumbers);
                generationThread.Start();
            }
        }

        private void GenerateNumbers()
        {
            RandomNumberGenerator rng = new RNGCryptoServiceProvider();

            while (isGenerating)
            {
                // Генеруємо випадкове число від 1 до 30
                byte[] randomNumber = new byte[4];
                rng.GetBytes(randomNumber);
                int number = Math.Abs(BitConverter.ToInt32(randomNumber, 0) % 30) + 1;

                // Додаємо згенероване число у текстове поле або консоль
                AddNumberToTextBox(number);

                // Затримка перед наступною генерацією числа
                Thread.Sleep(1000); // 1 секунда
            }
        }

        private void AddNumberToTextBox(int number)
        {
            if (txtGenerateNumbers.InvokeRequired)
            {
                txtGenerateNumbers.Invoke(new MethodInvoker(delegate
                {
                    txtGenerateNumbers.AppendText(number.ToString() + Environment.NewLine);
                }));
            }
            else
            {
                txtGenerateNumbers.AppendText(number.ToString() + Environment.NewLine);
            }
        }

        private void StopM3_Click(object sender, EventArgs e)
        {
            if (isGenerating)
            {
                isGenerating = false;
                StartM3.Enabled = true;
                StopM3.Enabled = false;

                // Зупиняємо потік генерації чисел
                generationThread.Abort();
            }
        }

        private void StartAll_Click(object sender, EventArgs e)
        {
            StartM1.PerformClick();
            StartM2.PerformClick();
            StartM3.PerformClick();
        }

        private void StopAll_Click(object sender, EventArgs e)
        {
            StopM1.PerformClick();
            StopM2.PerformClick();
            StopM3.PerformClick();
        }

        private void Task_Click(object sender, EventArgs e)
        {
            MessageBox.Show("У якості методів реалізувати криптографічні алгоритми, зазначені в завданнях. Метод 1(FEAL).Блоковий алгоритм шифрування; Метод 2(MD-2).Алгоритм хешування; Метод 3(Mceliece).Інші алгоритми шифрування й генерації випадкових чисел;","Завдання");
        }
    }
}
