using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class ExcelHelper
    {
        private static HSSFWorkbook workbook = null; //单例工厂

        private static ISheet sheet = null;

        private static IRow[] row;

        private static ICell[] icell;

        private static int division = 0;

        private static int IsExsitsHeads = 0;

        private static Dictionary<IRow[], ICell[]> Row_cell = new Dictionary<IRow[], ICell[]> { };

        public static Func<string> GetFilename; //打开文件对话框事件
        
        public static void CreateWork()  //创建工作簿
        {
            if (workbook==null)
            {
                workbook = new HSSFWorkbook();
                
            }
          
        }

        public static bool CreateSheet(string sheet_name) //创建表
        {

            if (workbook!=null)
            {
               sheet = workbook.CreateSheet(sheet_name);

               return true;
            }

            return false;
        }
        public static void CreateRow_Cell(int Rnum=0,int Cnum=0,int IsExsitsHead=0) //创建多少行与列 第三参数是否包含标题
        {
                division = Cnum;

                Rnum += IsExsitsHead;

                IsExsitsHeads = IsExsitsHead;

                row = new IRow[Rnum];
            
            icell = new ICell[Cnum];

            for (int i = 0; i < (Rnum); i++)
            {

                row[i] = sheet.CreateRow(i);

                for (int j = 0; j < (Cnum); j++)    
                {
                    icell[j]=row[i].CreateCell(j);
                }
               
 
            }

            Row_cell.Add(row, icell);

        }

        public static void SetCellHead(string[] str) //列的标题名
        {
            for (int i = 0; i < str.Count(); i++)
            {
                Row_cell.Keys.ElementAt(0)[0].GetCell(i).SetCellValue(str[i]);
                
            }

           
        }
        public static void Full(string[] str)  //添加内容
        {

            int count = 0;

            for (int i = IsExsitsHeads; i < Row_cell.Keys.ElementAt(0).Count(); i++)
            {
               

                for (int j = 0; j < division; j++)
                {


                    Row_cell.Keys.ElementAt(0)[i].GetCell(j).SetCellValue(str[count]);

                    count++;

                }
                
            }

        }

        public static void  Save(string path) //输出文件
        {

            System.IO.FileStream io = new System.IO.FileStream(path, System.IO.FileMode.Create,System.IO.FileAccess.ReadWrite);
           
            workbook.Write(io);

            io.Close();

            Free();
        }

        public static void Free()                   //释放资源
        {
            if (workbook != null)
            {
                workbook.Clear();

                workbook.Close();

                workbook = null;

            }
        }

        public static Dictionary<int,string[]> ImportExcell()
        {
           string path =  GetFilename();

            System.IO.FileStream io = new System.IO.FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);

            HSSFWorkbook work = new HSSFWorkbook(io);

            int row = work.GetSheetAt(0).LastRowNum;

            int colum = work.GetSheetAt(0).GetRow(0).LastCellNum;

            Dictionary<int, string[]> data = new Dictionary<int, string[]>();

            

            for (int i = 1; i < (row+1); i++)
            {
                string[] arr = new string[colum];

                for (int j = 0; j < colum; j++)
                {
                    arr[j] = work.GetSheetAt(0).GetRow (i).GetCell(j).StringCellValue;
                }

                data.Add(i, arr);
            }

            io.Close();

            return data;
        }
    }
}
