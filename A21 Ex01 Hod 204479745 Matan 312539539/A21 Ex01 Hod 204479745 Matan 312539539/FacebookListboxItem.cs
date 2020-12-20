using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class FacebookListboxItem
    {
        private string m_Name;
        private string m_ID;
        private eFacebookPostItemType m_ItemType;

        public FacebookListboxItem(string i_Name, string i_ID, eFacebookPostItemType i_ItemType)
        {
            m_Name = i_Name;
            m_ID = i_ID;
            m_ItemType = i_ItemType;
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public string ID
        {
            get
            {
                return m_ID;
            }
        }

        public eFacebookPostItemType ItemType
        {
            get
            {
                return m_ItemType;
            }
        }

        public enum eFacebookPostItemType
        {
            Friend,
            Group,
            Album,
            Event,
            Post,
            Status,
            Photo,
        }
        
    }
}
