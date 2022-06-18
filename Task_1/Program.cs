using Task_1;

Student st1 = new(1, "Viktor");
Student st2 = new(2, "asdg");

List<Mark> marks = new()
{
    new(1, 1, "Matan", 4),
    new(2, 1, "sql", 10)
};

void SetMark(Student st, List<Mark> mks)
{
    List<int> value = new();
    for (int i = 0; i < mks.Count; i++)
    {
        if (st.ID == mks[i].StudentID)
            value.Add(mks[i].Value);
    }
    st.Marks = value.ToArray();
}
SetMark(st1, marks);
foreach (var item in st1.Marks)
{
    Console.WriteLine(item);
}
Console.WriteLine(st1.GetAvgMark());
st1.ResetAllMarks();
foreach (var item in st1.Marks)
{
    Console.WriteLine(item);
}