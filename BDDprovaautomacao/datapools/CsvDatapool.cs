using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;

namespace FrameworkCsharp.Utils
{
    public class CsvDatapool
    {
        private readonly Dictionary<String, Int32> fieldLabels;
        private readonly List<List<string>> data;
        private int pointer;

        public CsvDatapool(string filePath)
        {
            this.fieldLabels = new Dictionary<string, int>();
            this.data = new List<List<string>>();

            ReadSheet(filePath);
            Reset();
        }

        public bool HasNext()
        {
            return this.pointer < data.Count;
        }

        public bool IsEmpty()
        {
            return data.Count <= 0;
        }

        public int GetSize()
        {
            return data.Count;
        }

        public CsvDatapool Next()
        {
            if (!this.HasNext())
            {
                Report.Log(LogStatus.Error, "Não há mais registros neste datapool. Utilize o método reset() para reiniciar o loop.");
            }

            this.pointer++;
            return this;
        }

        public CsvDatapool NextTo(int line)
        {
            if (line >= this.GetSize())
            {
                Report.Log(LogStatus.Error, "Há apenas " + this.GetSize() + " registros neste datapool.");
            }
            this.pointer = line;
            return this;
        }

        public CsvDatapool NextRandom()
        {
            Random random = new Random();
            this.pointer = random.Next(this.GetSize());
            return this;
        }

        public void Reset()
        {
            this.pointer = 0;
        }

        public void ReadSheet(string filePath)
        {
            try
            {
                StreamReader reader = new StreamReader(filePath, System.Text.Encoding.UTF8);
                string line = GetFieldLabels(reader);
                GetDataRows(reader, line);
                reader.Close();
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.StackTrace);
                Report.Log(LogStatus.Error, "Falha na leitura do csv");
            }
        }

        public String GetValue(String field)
        {
            if (this.fieldLabels.ContainsKey(field))
            {
                return this.GetValue(this.fieldLabels[field]);
            }

            Report.Log(LogStatus.Error, "O campo \"" + field + "\" não existe no datapool.");
            throw new ArgumentException("O campo \"" + field + "\" não existe no datapool.");
        }

        public List<string> GetList(String field)
        {
            if (this.fieldLabels.ContainsKey(field))
            {
                List<string> values = new List<string>();
                String[] valuesOutOfFormat = this.GetValue(this.fieldLabels[field]).Split(',');

                foreach (Object obj in valuesOutOfFormat)
                {
                    String valueWithoutSpaces = obj.ToString().Replace(" ", "");
                    values.Add(valueWithoutSpaces);
                }

                return values;
            }

            Report.Log(LogStatus.Error, "O campo \"" + field + "\" não existe no datapool.");
            throw new ArgumentException("O campo \"" + field + "\" não existe no datapool.");
        }

        public String GetValue(int fieldIndex)
        {
            return this.data[this.pointer][fieldIndex];
        }

        public void GetDataRows(StreamReader reader, string actualLine)
        {
            while (actualLine != null)
            {
                List<string> fields = new List<string>();
                foreach (string field in actualLine.Split(';'))
                {
                    fields.Add(field);
                }
                data.Add(fields);
                actualLine = reader.ReadLine();
            }
        }

        private String GetFieldLabels(StreamReader reader)
        {
            int index = 0;
            String line = reader.ReadLine();
            foreach (String fieldLabel in line.Split(';'))
            {
                fieldLabels.Add(fieldLabel, index++);
            }

            line = reader.ReadLine();
            return line;
        }
    }
}