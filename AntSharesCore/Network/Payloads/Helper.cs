namespace AntShares.Network.Payloads
{
    internal static class Helper
    {
        //Ҫ��֤���ص��ַ�����UTF8����󣬳���С�ڻ����12���ֽ�
        public static string GetCommandName(this InventoryType type)
        {
            //TODO: ��ʱ����ö�����ƣ�δ�����ܻ���ö���������������Ʋ�һ�µ��������Ҫ��������
            return type.ToString().ToLower();
        }
    }
}
