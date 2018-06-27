using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETModel;
using UnityEngine.UI;

namespace ETHotfix
{
    [ObjectSystem]
    public class UILoginComponentAwakeSystem : AwakeSystem<UILoginComponent>
    {
        public override void Awake(UILoginComponent self)
        {
            self.Awake();
        }
    }

    public class UILoginComponent : UIBaseComponent//�˴��̳���UIBaseComponent������Component
    {
        //Awake����ֻ����һ�Σ�ͨ�����ڻ�ȡ���ã����¼�����ʼ�����ֵ���
        public void Awake()
        {
            //��ȡReferenceCollector������
            ReferenceCollector rc = this.GetParent<UI_Z>().GameObject.GetComponent<ReferenceCollector>();

            //ͨ��ReferenceCollector��ȡ��ӵ���������
            //�˴���ȡ���ذ�ť��Button��������Ұ󶨵���¼�
            rc.GetUnityComponent<Button>("ReturnBtn").Add(OnClickReturnBtn);
        }

        //ÿ��Show���嶼����ã�ͨ�����ڳ�ʼ������
        public override void Show()
        {
            base.Show();

            //չʾ�����߼�
        }

        //�ر�ʱ����
        public override void Close()
        {
            base.Close();

            //�رս����߼�
        }

        //������ذ�ť�¼�
        private void OnClickReturnBtn()
        {
            //����˳������߼�
        }
    }
}