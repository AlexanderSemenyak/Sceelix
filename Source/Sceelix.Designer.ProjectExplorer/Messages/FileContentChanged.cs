﻿using Sceelix.Designer.ProjectExplorer.Management;

namespace Sceelix.Designer.ProjectExplorer.Messages
{
    public class FileContentChanged
    {
        private readonly FileItem _item;



        public FileContentChanged(FileItem item)
        {
            _item = item;
        }



        public FileItem Item
        {
            get { return _item; }
        }
    }
}