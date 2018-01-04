using System.Xml;


namespace Framework
{
    public class Configuration
    {
        private static string browser;
        private static string url;
        private static string lang;
        private static int implicitWait;
        private static string filename;
        private static string year;
        private static string culture;
        private static int pageLoadTime;
        private static int implicitForPage;
        private static string scriptPath;
        private static int taskDelay;
        private static int countLoop;

        private static readonly XmlReader reader = XmlReader.Create("D:\\config.xml");
        private static XmlNodeType node;

        public static void ReadXml()
        {   
            while (reader.Read())
            {
                node = reader.NodeType;
                if (node == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "browser":
                            reader.Read();
                            browser = reader.Value;
                            break;
                        case "url":
                            reader.Read();
                            url = reader.Value;
                            break;
                        case "language":
                            reader.Read();
                            lang = reader.Value;
                            break;
                        case "implicitWait":
                            reader.Read();
                            implicitWait = int.Parse(reader.Value);
                            break;
                        case "filename":
                            reader.Read();
                            filename = reader.Value;
                            break;
                        case "year":
                            reader.Read();
                            year = reader.Value;
                            break;
                        case "culture":
                            reader.Read();
                            culture = reader.Value;
                            break;
                        case "pageLoadTime":
                            reader.Read();
                            pageLoadTime = int.Parse(reader.Value);
                            break;
                        case "implicitForPage":
                            reader.Read();
                            implicitForPage = int.Parse(reader.Value);
                            break;
                        case "scriptPath":
                            reader.Read();
                            scriptPath  = @reader.Value;
                            break;
                        case "taskDelay":
                            reader.Read();
                            taskDelay = int.Parse(reader.Value);
                            break;
                        case "countLoop":
                            reader.Read();
                            countLoop = int.Parse(reader.Value);
                            break;
                    }
                }
           }
            reader.Close();
        }

        public static string GetBrowser()
        {
            ReadXml();
            return browser;
        }

        public static string GetUrl()
        {
            ReadXml();
            return url;
        }

        public static string GetLanguage()
        {
            ReadXml();
            return lang;
        }

        public static int GetTimeWait()
        {
            ReadXml();
            return implicitWait;
        }

        public static string GetFileName()
        {
            ReadXml();
            return filename;
        }

        public static string GetYear()
        {
            ReadXml();
            return year;
        }

        public static string GetCulture()
        {
            ReadXml();
            return culture;
        }

        public static int GetPageLoadTime()
        {
            ReadXml();
            return pageLoadTime;
        }

        public static int GetImplicitForPage()
        {
            ReadXml();
            return implicitForPage;
        }

        public static string GetScriptPath()
        {
            ReadXml();
            return scriptPath;
        }

        public static int GetTaskDelay()
        {
            ReadXml();
            return taskDelay;
        }

        public static int GetCountLoop()
        {
            ReadXml();
            return countLoop;
        }
    }
}
