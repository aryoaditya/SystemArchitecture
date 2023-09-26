namespace LibraryApp
{
    public class MemberManagement
    {
        private List<Member> memberList = new List<Member>();

        public void Add(Member member)
        {
            // Logika untuk menambah anggota ke daftar anggota
            memberList.Add(member);
        }

        public void Edit(int id, Member member)
        {
            // Logika untuk mengedit anggota berdasarkan ID
            var updatedMember = memberList.FirstOrDefault(a => a.ID == id);
            if (updatedMember != null)
            {
                updatedMember.Nama = member.Nama;
                updatedMember.AlamatEmail = member.AlamatEmail;
                updatedMember.NomorKeanggotaan = member.NomorKeanggotaan;
            }
        }

        public void Delete(int id)
        {
            // Logika untuk menghapus anggota berdasarkan ID
            var deleteMember = memberList.FirstOrDefault(a => a.ID == id);
            if (deleteMember != null)
            {
                memberList.Remove(deleteMember);
            }
        }

        public List<Member> MemberList()
        {
            // Logika untuk melihat daftar anggota
            return memberList;
        }
    }
}
