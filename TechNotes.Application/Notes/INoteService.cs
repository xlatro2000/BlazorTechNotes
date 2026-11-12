using System;
using TechNotes.Domain;

namespace TechNotes.Application.Notes;

public interface INoteService
{
    List<Note> GetAllNotes();

}
