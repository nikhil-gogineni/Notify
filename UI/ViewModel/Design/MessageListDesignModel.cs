using DomainModel.DTO;
using DomainModel;

namespace UI
{
    public class MessageListDesignModel : MessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MessageListDesignModel Instance => new MessageListDesignModel();

        #endregion



        #region Constructor

        public MessageListDesignModel()
        {
            try
            {
                SyncAPI aPI = new SyncAPI("http://localhost:56893/api/", null);

                var items = aPI.Get<Message>("Message/GetMessages?empID=0");
            }
            catch (System.Exception e)
            {

            }
        }

        #endregion
    }
}
