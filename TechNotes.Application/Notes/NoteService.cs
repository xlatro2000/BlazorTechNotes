using System;
using System.Data.Common;
using TechNotes.Domain;

namespace TechNotes.Application.Notes;

public class NoteService : INoteService
{
    public List<Note> GetAllNotes()
    {
        List<Note> notes = new List<Note>
        {
            new()
            {
                Id=1, Title="Nota 1", Content="Contenido1", CreatedAt= DateTime.Now, IsPublished=true, PublishedAt=DateTime.Now
            },
            new()
            {
                Id=2, Title="Nota 2", Content="Contenido2", CreatedAt= DateTime.Now
            }
        };
        return notes;
    }
}
