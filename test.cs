
            string xmlFilePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"WinFormExamples\WinFormExamples\ServerList.xml");

            XDocument xDoc = XDocument.Load(xmlFilePath);

            var servers =
                xDoc.Root.Elements("Server")
                .Select(n =>
                    new AppServer
                    {
                        Name = (string)n.Attribute("name"),
                        Class = (string)n.Attribute("env"),
                    })
                .ToList();

            BindingSource bs = new BindingSource();
