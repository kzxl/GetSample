using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EasyFunctions
{
    public class clsFunctions
    {
        /// <summary>
        /// Lấy danh sách các IPv4 đang sử dụng
        /// </summary>
        /// <returns>trả về danh sách IPv4</returns>
        public static List<string>? GetIPv4()
        {
            try
            {
                List<string> lstIP = new List<string>();
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    if (adapter.OperationalStatus == OperationalStatus.Up && adapter.GetIPProperties().GatewayAddresses.Count > 0)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        var ip = properties.UnicastAddresses.Where(ua => ua.Address.AddressFamily == AddressFamily.InterNetwork).Select(ua => ua.Address.ToString()).FirstOrDefault();
                        lstIP.Add(ip);
                    }
                }
                return lstIP;
            }
            catch { return null; }
        }
        /// <summary>
        /// Lấy tên máy tính đang sử dụng
        /// </summary>
        /// <returns>trả về tên máy tính</returns>
        public static string GetComputerName()
        {
            try
            {
                return Environment.MachineName;
            }
            catch (Exception) { return ""; }
        }
        /// <summary>
        /// Chuyển tiếng việt không dấu
        /// </summary>
        /// <param name="s">Chuỗi cần chuyển</param>
        /// <returns>trả về chuỗi tiếng việt không dấu</returns>
        public static string ChuyenKhongDau(string s)
        {
            try
            {
                s = s.Replace(" ", "_").Replace("~", "-").Replace("`", "-").Replace("!", "-").Replace("@", "-").Replace("#", "-").Replace("$", "-").Replace("%", "-").Replace("^", "-").Replace("&", "-").Replace("*", "-").Replace("(", "-").Replace(")", "-").Replace("+", "-").Replace("=", "-").Replace("'", "-");
                string stFormD = s.Normalize(NormalizationForm.FormD);
                StringBuilder sb = new StringBuilder();
                for (int ich = 0; ich < stFormD.Length; ich++)
                {
                    System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                    if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                    {
                        sb.Append(stFormD[ich]);
                    }
                }
                sb = sb.Replace('Đ', 'D');
                sb = sb.Replace('đ', 'd');
                string name = (sb.ToString().Normalize(NormalizationForm.FormD));
                if (name.Length > 100)
                {
                    throw new Exception("Tên tập tin không dài quá 100 ký tự");
                }
                return name;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Kiểm tra có phải số hay không
        /// </summary>
        /// <param name="pValue">giá trị cần kiểm tra</param>
        /// <returns>true hoặc false</returns>
        public static bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Chuyển số thành chữ
        /// </summary>
        /// <param name="inputNumber">Số cần chuyển</param>
        /// <param name="suffix"></param>
        /// <returns>chuỗi giá trị bằng chữ</returns>
        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            try
            {
                string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
                bool isNegative = false;

                // -12345678.3445435 => "-12345678"
                string sNumber = inputNumber.ToString("#");
                double number = Convert.ToDouble(sNumber);
                if (number < 0)
                {
                    number = -number;
                    sNumber = number.ToString();
                    isNegative = true;
                }


                int ones, tens, hundreds;

                int positionDigit = sNumber.Length;   // last -> first

                string result = " ";


                if (positionDigit == 0)
                    result = unitNumbers[0] + result;
                else
                {
                    // 0:       ###
                    // 1: nghìn ###,###
                    // 2: triệu ###,###,###
                    // 3: tỷ    ###,###,###,###
                    int placeValue = 0;

                    while (positionDigit > 0)
                    {
                        // Check last 3 digits remain ### (hundreds tens ones)
                        tens = hundreds = -1;
                        ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                            if (positionDigit > 0)
                            {
                                hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                                positionDigit--;
                            }
                        }

                        if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                            result = placeValues[placeValue] + result;

                        placeValue++;
                        if (placeValue > 3) placeValue = 1;

                        if ((ones == 1) && (tens > 1))
                            result = "một " + result;
                        else
                        {
                            if ((ones == 5) && (tens > 0))
                                result = "lăm " + result;
                            else if (ones > 0)
                                result = unitNumbers[ones] + " " + result;
                        }
                        if (tens < 0)
                            break;
                        else
                        {
                            if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                            if (tens == 1) result = "mười " + result;
                            if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                        }
                        if (hundreds < 0) break;
                        else
                        {
                            if ((hundreds > 0) || (tens > 0) || (ones > 0))
                                result = unitNumbers[hundreds] + " trăm " + result;
                        }
                        result = " " + result;
                    }
                }
                result = result.Trim();
                if (result.Length > 1)
                {
                    string rs1 = result.Substring(0, 1);
                    rs1 = rs1.ToUpper();
                    result = result.Substring(1);
                    result = rs1 + result;
                }
                if (isNegative) result = "Âm " + result;
                return result + (suffix ? " đồng chẵn" : "");
            }
            catch (Exception) { return null; }
        }
        
        
    }

    #region Convert Data
    public static class ObjectExtensions
    {
        public static string _Number_StringOrEmpty(this object value)
        {
            try
            {
                if (value == null || value.ToString().Trim() == "")
                {
                    return "";
                }
                else
                {
                    return Convert.ToDecimal(value).ToString();
                }

            }
            catch (Exception)
            {
                return "";
            }
        }
        public static decimal _Decimal(this object value)
        {
            try
            {
                return Convert.ToDecimal(value);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string _ddMMyyyyOrEmpty(this object value)
        {
            try
            {
                if (value == null || value.ToString().Trim() == "")
                {
                    return "";
                }
                else
                {
                    return Convert.ToDateTime(value).ToString("dd/MM/yyyy");
                }

            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string _ddMMyyyyHHmmssOrEmpty(this object value)
        {
            try
            {
                if (value == null || value.ToString().Trim() == "")
                {
                    return "";
                }
                else
                {
                    return Convert.ToDateTime(value).ToString("dd/MM/yyyy HH:mm:ss");
                }

            }
            catch (Exception)
            {
                return "";
            }
        }
        public static DateTime _DateTime(this object value)
        {
            try
            {
                return Convert.ToDateTime(value);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DateTime? _DateTimeOrNull(this object value)
        {
            try
            {
                if (value == null || value.ToString().Trim() == "")
                {
                    return null;
                }
                else
                {
                    return Convert.ToDateTime(value);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int? _IntOrNull(this object value)
        {
            try
            {
                if (value == null || value.ToString().Trim() == "")
                {
                    return null;
                }
                else
                {
                    return Convert.ToInt32(value);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int _Int(this object value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool? _BooleanOrNull(this object value)
        {
            try
            {
                return Convert.ToBoolean(value);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool _Boolean(this object value)
        {
            try
            {
                return Convert.ToBoolean(value);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
    #endregion
}
