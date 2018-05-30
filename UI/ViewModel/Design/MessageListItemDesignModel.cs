using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class MessageListItemDesignModel : MessageListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MessageListItemDesignModel Instance => new MessageListItemDesignModel();

        #endregion

        #region Constructor

        public MessageListItemDesignModel()
        {
            Initials = "SK";
            Sender = new User() { Name = "SaiLatha Kanumuri"};
            Subject = "Session Topics";
            ProfilePictureRGB = "#3099c5";
        }

        #endregion
    }
}
