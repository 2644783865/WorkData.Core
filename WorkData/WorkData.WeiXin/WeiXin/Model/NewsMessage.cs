using System.Collections.Generic;
using Newtonsoft.Json;

namespace WorkData.WeiXin.WeiXin.Model
{
    /// <summary>
    /// ΢������
    /// </summary>
    public class WeiXinArticle
    {
        /// <summary>
        /// ����
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; } = "";

        /// <summary>
        /// �������ת�����ӡ�
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; } = "";

        /// <summary>
        /// ͼ����Ϣ��ͼƬ���ӣ�֧��JPG��PNG��ʽ���Ϻõ�Ч��Ϊ��ͼ640*320��Сͼ80*80���粻��ڿͻ��˲���ʾͼƬ
        /// </summary>
        [JsonProperty("picurl")]
        public string Picurl { get; set; } = "";

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    ///���ż���
    /// </summary>
    public class NewsCollect
    {
        /// <summary>
        ///������ ͼ����Ϣ��һ��ͼ����Ϣ֧��1��10��ͼ��
        /// </summary>
        [JsonProperty("articles")]
        public List<WeiXinArticle> Articles { get; set; } = new List<WeiXinArticle>(10);

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// ������Ϣ
    /// </summary>
    public class NewsMessage
    {
        /*
           {
           "touser": "UserID1|UserID2|UserID3",
           "toparty": " PartyID1 | PartyID2 ",
           "totag": " TagID1 | TagID2 ",
           "msgtype": "news",
           "agentid": "1",
           "news": {
               "articles":[
                   {
                       "title": "Title",
                       "description": "Description",
                       "url": "URL",
                       "picurl": "PIC_URL"
                   },
                   {
                       "title": "Title",
                       "description": "Description",
                       "url": "URL",
                       "picurl": "PIC_URL"
                   }
               ]
           }
        }
        */

        /// <summary>
        /// ��ԱID�б���Ϣ�����ߣ�����������á�|���ָ������֧��1000���������������ָ��Ϊ@all�������ע����ҵӦ�õ�ȫ����Ա����
        /// </summary>
        [JsonProperty("touser")]
        public string ToUser { get; set; }

        /// <summary>
        /// ����ID�б�����������á�|���ָ������֧��100������touserΪ@allʱ���Ա�����
        /// </summary>
        [JsonProperty("toparty")]
        public string ToParty { get; set; }

        /// <summary>
        /// ��ǩID�б�����������á�|���ָ�����touserΪ@allʱ���Ա�����
        /// </summary>
        [JsonProperty("totag")]
        public string ToTag { get; set; }

        /// <summary>
        ///������ ��Ϣ���ͣ���ʱ�̶�Ϊ��news
        /// </summary>
        [JsonProperty("msgtype")]
        public string MsgType { get; } = "news";

        /// <summary>
        ///������ ��ҵӦ�õ�id�����͡�����Ӧ�õ�����ҳ��鿴
        /// </summary>
        [JsonProperty("agentid")]
        public string AgentId { get; set; }

        /// <summary>
        /// ��Ϣ��
        /// </summary>
        [JsonProperty("news")]
        public NewsCollect News { get; set; } = new NewsCollect();

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}