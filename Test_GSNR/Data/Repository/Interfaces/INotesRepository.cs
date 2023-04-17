using Test_GSNR.Models;

namespace Test_GSNR.Data.Repository;

public interface INotesRepository
{
    IEnumerable<NoteItem> GetAllNotes();

    void AddNote(string name, string description);

    void EditNote(NoteItem noteItem);

    void DeleteNote(int id);

    NoteItem FindNoteById(int Id);
}
