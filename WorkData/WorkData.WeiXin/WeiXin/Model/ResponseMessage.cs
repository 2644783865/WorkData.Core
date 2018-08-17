using Newtonsoft.Json;

namespace WorkData.WeiXin.WeiXin.Model
{
    public class ResponseMessage
    {
        /*
        {
   "errcode": 0,
   "errmsg": "ok",
   "invaliduser": "UserID1",
   "invalidparty":"PartyID1",
   "invalidtag":"TagID1"
}
            */

        /// <summary>
        /// ������
        /// </summary>
        [JsonProperty("errcode")]
        public int ErrCode { get; set; }

        /// <summary>
        ///������Ϣ
        /// </summary>
        [JsonProperty("errmsg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// ��Ч�û��б�
        /// </summary>
        [JsonProperty("invaliduser")]
        public string InvalidUser { get; set; }

        /// <summary>
        /// ��Ч�����б�
        /// </summary>
        [JsonProperty("invalidparty")]
        public string InvalidParty { get; set; }

        /// <summary>
        /// ��Ч��ǩ�б�
        /// </summary>
        [JsonProperty("invalidtag")]
        public string InvalidTag { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}