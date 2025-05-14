using OOP.Classes.FabricPattern.Creators;
using System;
using System.Drawing;
using System.Windows.Forms;
using OOP.Classes.MainDrawingModule;
using OOP.Classes.Fabric_Pattern;
using Microsoft.VisualBasic;


namespace OOP
{
    public partial class Drawer : Form
    {
        private DrawingManager drawingManager = new DrawingManager();
        private bool isDrawing = false;
        private bool isPolygonMode = false;
        private int polygonVerticesRequired = 0;
        private int polygonVerticesDrawn = 0;

        public Drawer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            drawingManager.DrawAll(e.Graphics);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!isDrawing)
                {
                    drawingManager.StartDrawing(e.Location);
                    isDrawing = true;
                }
                else
                {
                    drawingManager.AddPointToCurrentShape(e.Location);

                    if (isPolygonMode)
                    {
                        polygonVerticesDrawn++;
                        if (polygonVerticesDrawn >= polygonVerticesRequired)
                        {
                            drawingManager.EndDrawing(e.Location);
                            isDrawing = false;
                            isPolygonMode = false;
                        }
                    }
                }
            }
            else if (e.Button == MouseButtons.Right && isDrawing)
            {
                drawingManager.EndDrawing(e.Location);
                isDrawing = false;
            }

            this.Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                drawingManager.UpdateDrawing(e.Location);
                this.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            drawingManager.SetShapeCreator(new LineCreator());
            ResetDrawingState();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            drawingManager.SetShapeCreator(new RectangleCreator());
            ResetDrawingState();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            drawingManager.SetShapeCreator(new EllipseCreator());
            ResetDrawingState();
        }

        private void BrokenLineButton_Click(object sender, EventArgs e)
        {
            drawingManager.SetShapeCreator(new PolylineCreator());
            ResetDrawingState();
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Введите количество вершин многоугольника:", "Создание многоугольника", "5");

            if (int.TryParse(input, out int sides) && sides >= 3)
            {
                drawingManager.SetShapeCreator(new PolygonCreator(sides));
            }
            else
            {
                MessageBox.Show("Некорректное количество вершин. Нужно ввести число >= 3.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BrushThiknessButton_Click(object sender, EventArgs e)
        {
            using (var form = new Form())
            using (var numeric = new NumericUpDown())
            {
                numeric.Minimum = 1;
                numeric.Maximum = 20;
                numeric.Value = drawingManager.StrokeWidth;
                numeric.Dock = DockStyle.Fill;

                form.Text = "Толщина кисти";
                form.ClientSize = new Size(200, 60);
                form.Controls.Add(numeric);
                form.StartPosition = FormStartPosition.CenterParent;

                var okButton = new Button { Text = "OK", Dock = DockStyle.Bottom };
                okButton.Click += (s, args) =>
                {
                    drawingManager.StrokeWidth = (int)numeric.Value;
                    form.Close();
                };
                form.Controls.Add(okButton);

                form.ShowDialog(this);
            }
        }

        private void BrushColorButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    drawingManager.StrokeColor = dialog.Color;
                }
            }
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    drawingManager.FillColor = dialog.Color;
                }
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рисовалка фигур\n\nЛКМ — добавление точек.\nПКМ — завершение ломаной.\nПри создании многоугольника вводится число вершин.",
                          "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetDrawingState()
        {
            isDrawing = false;
            isPolygonMode = false;
            polygonVerticesDrawn = 0;
        }

        private void polygonButton_Click_1(object sender, EventArgs e)
        {
            using (var inputForm = new Form())
            using (var numeric = new NumericUpDown())
            {
                numeric.Minimum = 3;
                numeric.Maximum = 100;
                numeric.Value = 3;
                numeric.Dock = DockStyle.Fill;

                inputForm.Text = "Количество вершин";
                inputForm.ClientSize = new Size(200, 60);
                inputForm.Controls.Add(numeric);
                inputForm.StartPosition = FormStartPosition.CenterParent;

                var okButton = new Button { Text = "OK", Dock = DockStyle.Bottom };
                okButton.Click += (s, args) =>
                {
                    int sides = (int)numeric.Value;
                    drawingManager.SetShapeCreator(new PolygonCreator(sides));
                    inputForm.Close();
                };
                inputForm.Controls.Add(okButton);

                inputForm.ShowDialog(this);
            }

            ResetDrawingState();
        }
    }
}
