﻿using Microsoft.AspNetCore.Mvc;
using Test_GSNR.Data;
using Test_GSNR.Data.Repository;
using Test_GSNR.Models;

namespace Test_GSNR.Services.Repositories;

public class NoteRepository : INotesRepository
{
    private readonly NotesDb _context;

    public NoteRepository(NotesDb context)
    {
        _context = context;
    }

    public void AddNote(string name, string description)
    {
        var note = new NoteItem()
        {
            Title = name,
            Description = description,
        };

        _context.Notes.Add(note);
        _context.SaveChanges();
    }

    public void DeleteNote(int id)
    {
        var note = _context.Notes.Find(id);
        if (note != null)
        {
            _context.Notes.Remove(note);
            _context.SaveChanges();
        }
    }

    public void EditNote(NoteItem noteItem)
    {
        var note = _context.Notes.Attach(noteItem);
        note.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        _context.SaveChanges();
    }

    public IEnumerable<NoteItem> GetAllNotes()
    {
        return _context.Notes;
    }

    public NoteItem FindNoteById(int Id) => _context.Notes.Find(Id);
}
