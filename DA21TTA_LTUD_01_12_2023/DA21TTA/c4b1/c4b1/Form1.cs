using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c4b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lbDanhSach.Items.IndexOf(txtThem.Text) >= 0)
            {
                lbDanhSach.SelectedItem = txtThem.Text;
            }
            else if (txtThem.Text != "")
            {
                lbDanhSach.Items.Add(txtThem.Text);
                txtThem.Text = "";
            }
        }

        private void btnPhai1_Click(object sender, EventArgs e)
        {
            if (lbDanhSach.SelectedItem != null)
            {
                string selectedItem = lbDanhSach.SelectedItem.ToString();
                int demTrung = CountOccurrences(lbDaChon.Items, selectedItem) + 1;

                if (demTrung > 1)
                {
                    lbDaChon.Items.Add($"{demTrung} {selectedItem}");
                }
                else
                {
                    lbDaChon.Items.Add(selectedItem);
                }
            }
        }

        private void btnTrai1_Click(object sender, EventArgs e)
        {
            if (lbDaChon.SelectedItem != null)
            {
                lbDanhSach.Items.Add(lbDaChon.SelectedItem);
                lbDaChon.Items.Remove(lbDaChon.SelectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDanhSach.Items.Add("Cá kèo kho");
            lbDanhSach.Items.Add("Cá lóc kho");
            lbDanhSach.Items.Add("Canh cải");
            lbDanhSach.Items.Add("Canh chua cá lóc");
        }

        private void btnPhai2_Click(object sender, EventArgs e)
        {
            foreach (string item in lbDanhSach.SelectedItems)
            {
                int demTrung = CountOccurrences(lbDaChon.Items, item) + 1;

                if (demTrung > 1)
                {
                    lbDaChon.Items.Add($"{demTrung} {item}");
                }
                else
                {
                    lbDaChon.Items.Add(item);
                }
            }
        }

        private int CountOccurrences(ListBox.ObjectCollection items, string itemToCount)
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.ToString() == itemToCount)
                {
                    count++;
                }
            }

            return count;
        }

        private void btnTrai2_Click(object sender, EventArgs e)
        {
            if (lbDaChon.SelectedItems.Count > 0)
            {
                for (int i = lbDaChon.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lbDaChon.Items.Remove(lbDaChon.SelectedItems[i]);
                }
            }
            else
            {
                // Nếu không có item nào được chọn, xóa hết item trong lbDaChon
                lbDaChon.Items.Clear();
            }
        }

        private void btnLen_Click(object sender, EventArgs e)
        {
            MoveItems(-1); // Di chuyển lên 1 hàng
        }

        private void btnXuong_Click(object sender, EventArgs e)
        {
            MoveItems(+1); // Di chuyển xuống 1 hàng
        }

        private void MoveItems(int offset)
        {
            ListBox.SelectedIndexCollection selectedIndices = lbDaChon.SelectedIndices;

            // Kiểm tra xem có ít nhất một item được chọn
            if (selectedIndices.Count > 0)
            {
                // Di chuyển từng item lên (hoặc xuống) theo offset
                foreach (int index in selectedIndices)
                {
                    int newIndex = index + offset;

                    // Kiểm tra giới hạn không vượt quá biên độ của ListBox
                    if (newIndex >= 0 && newIndex < lbDaChon.Items.Count)
                    {
                        object selectedItem = lbDaChon.Items[index];
                        lbDaChon.Items.RemoveAt(index);
                        lbDaChon.Items.Insert(newIndex, selectedItem);

                        // Cập nhật selectedIndex để đảm bảo item vẫn được chọn sau khi di chuyển
                        lbDaChon.SetSelected(newIndex, true);
                    }
                }
            }
        }

    }
}
