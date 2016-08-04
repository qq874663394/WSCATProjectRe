using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace HelperUtility.ExUI
{
    public partial class MultiHeaderView : DataGridView
    {
        public MultiHeaderView()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: 在此处添加自定义绘制代码

            // 调用基类 OnPaint
            base.OnPaint(pe);
        }
        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                //二维表头
                if (e.RowIndex == -1)
                {
                    if (SpanRows.ContainsKey(e.ColumnIndex)) //被合并的列
                    {
                        //画边框
                        Graphics g = e.Graphics;
                        e.Paint(e.CellBounds,
                            DataGridViewPaintParts.Background |
                            DataGridViewPaintParts.Border);

                        int left = e.CellBounds.Left, top = e.CellBounds.Top + 2,
                        right = e.CellBounds.Right, bottom = e.CellBounds.Bottom;

                        switch (SpanRows[e.ColumnIndex].Position)
                        {
                            case 1:
                                left += 2;
                                break;
                            case 2:
                                break;
                            case 3:
                                right -= 2;
                                break;
                        }

                        //画上半部分底色
                        g.FillRectangle(new SolidBrush(this._mergecolumnheaderbackcolor), left, top,
                        right - left, (bottom - top) / 2);

                        //画中线
                        g.DrawLine(new Pen(this.GridColor), left, (top + bottom) / 2,
                        right, (top + bottom) / 2);

                        //写小标题
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        g.DrawString(e.Value + "", e.CellStyle.Font, Brushes.Black,
                        new Rectangle(left, (top + bottom) / 2, right - left, (bottom - top) / 2), sf);
                        left = this.GetColumnDisplayRectangle(SpanRows[e.ColumnIndex].Left, true).Left - 2;

                        if (left < 0) left = this.GetCellDisplayRectangle(-1, -1, true).Width;
                        right = this.GetColumnDisplayRectangle(SpanRows[e.ColumnIndex].Right, true).Right - 2;
                        if (right < 0) right = this.Width;

                        g.DrawString(SpanRows[e.ColumnIndex].Text, e.CellStyle.Font, Brushes.Black,
                        new Rectangle(left, top, right - left, (bottom - top) / 2), sf);
                        e.Handled = true;
                    }
                }
                base.OnCellPainting(e);
            }
            catch
            { }
        }
        #region 二维表头属性
        private struct SpanInfo //表头信息
        {
            public SpanInfo(string Text, int Position, int Left, int Right)
            {
                this.Text = Text;
                this.Position = Position;
                this.Left = Left;
                this.Right = Right;
            }

            public string Text; //列主标题
            public int Position; //位置，1:左，2中，3右
            public int Left; //对应左行
            public int Right; //对应右行
        }
        private Dictionary<int, SpanInfo> SpanRows = new Dictionary<int, SpanInfo>();//需要2维表头的列
        /// <summary>
        /// 合并列
        /// </summary>
        /// <param name="ColIndex">列的索引</param>
        /// <param name="ColCount">需要合并的列数</param>
        /// <param name="Text">合并列后的文本</param>
        public void AddSpanHeader(int ColIndex, int ColCount, string Text)
        {
            if (ColCount < 2)
            {
                throw new Exception("行宽应大于等于2，合并1列无意义。");
            }
            //将这些列加入列表 
            int Right = ColIndex + ColCount - 1; //同一大标题下的最后一列的索引
            SpanRows[ColIndex] = new SpanInfo(Text, 1, ColIndex, Right); //添加标题下的最左列
            SpanRows[Right] = new SpanInfo(Text, 3, ColIndex, Right); //添加该标题下的最右列
            for (int i = ColIndex + 1; i < Right; i++) //中间的列
            {
                SpanRows[i] = new SpanInfo(Text, 2, ColIndex, Right);
            }
        }

        private void DataGridViewEx_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)// && e.Type == ScrollEventType.EndScroll)
            {
                timer1.Enabled = false; timer1.Enabled = true;
            }
        }
        //刷新显示表头
        public void ReDrawHead()
        {
            foreach (int si in SpanRows.Keys)
            {
                this.Invalidate(this.GetCellDisplayRectangle(si, -1, true));
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ReDrawHead();
        }
        /// <summary>
        /// 二维表头的背景颜色
        /// </summary>
        [Description("二维表头的背景颜色"), Browsable(true), Category("二维表头")]
        public Color MergeColumnHeaderBackColor
        {
            get { return this._mergecolumnheaderbackcolor; }
            set { this._mergecolumnheaderbackcolor = value; }
        }
        private Color _mergecolumnheaderbackcolor = System.Drawing.SystemColors.Info;
        #endregion
    }
}
