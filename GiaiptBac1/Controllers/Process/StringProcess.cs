using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace GiaiptBac1.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string ID)
        {
            //Khai bao cac tham so du lieu dau vao
            string numPart, strPart, newKey = "", newNumPart="";
            int intNumber;
            //Tham so dau vao CMT0001
            //Phan so
            numPart = Regex.Match(ID, @"\d+").Value;
            intNumber = Convert.ToInt32(numPart) + 1;
            for (int i = 0; i < numPart.Length - intNumber.ToString().Length; i++)
            {
                newNumPart += "0";
            }
            newNumPart += intNumber;
            //Phan ky tu
            strPart = numPart = Regex.Match(ID, @"\D+").Value;
            newKey = strPart + newNumPart;
            return newKey;
        }
    }
}