import json
import os
import datetime
# Реализовать консольное приложение заметки, с сохранением, чтением,
# добавлением, редактированием и удалением заметок. Заметка должна
# содержать идентификатор, заголовок, тело заметки и дату/время создания или
# последнего изменения заметки. Сохранение заметок необходимо сделать в
# формате json или csv формат (разделение полей рекомендуется делать через
# точку с запятой). Реализацию пользовательского интерфейса студент может
# делать как ему удобнее, можно делать как параметры запуска программы
# (команда, данные), можно делать как запрос команды с консоли и
# последующим вводом данных, как-то ещё, на усмотрение студента.

filename = "theNote.json"

def create_note_file():
    with open(filename, "w") as file:
        json.dump([], file)

def load_note():
    try:
        with open(filename, "r") as file:
            note = json.load(file)
    except (json.JSONDecodeError, FileNotFoundError):
        create_note_file()
        note = []
    return note

def create_note(notes, title, message):
    note_id = len(notes) + 1
    timestamp = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
    note = {"id": note_id, "title": title, "message": message, "timestamp": timestamp}
    notes.append(note)
    return notes

# save notes in file
def save_notes(notes):
    with open(filename, "w") as file:
        json.dump(notes, file, indent=4)
        
def edit_note(notes, note_id, new_title, new_message):
    for note in notes:
        if note["id"] == note_id:
            note["title"] = new_title
            note["message"] = new_message
            note["timestamp"] = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
            break
    else:
        print("Note is this ID not found")
    return notes

def delete_note(notes, note_id):
    notes = [note for note in notes if note["id"] != note_id]
    return notes

def show_note(notes, note_id):
    for note in notes:
        if note["id"] == note_id:
            print(f"ID: {note['id']}, Header: {note['title']}, Текст: {note['message']}, Create date: {note['timestamp']}")
            break
    else:
        print("Notes not found")

def main():
    notes = load_note()

    while True:
        command = input("Enter you command (add/read/edit/delete/show/exit): ")

        if command == "add":
            title = input("Enter header in you note : ")
            message = input("Enter you text: ")
            notes = create_note(notes, title, message)
            save_notes(notes)
            print("Save succefull")
        elif command == "read":
            for note in notes:
                print(f"ID: {note['id']}, Headrer is : {note['title']}, Create date: {note['timestamp']}")
        elif command == "edit":
            note_id = int(input("Please enter ID you note for edition : "))
            new_title = input("Entere new header : ")
            new_message = input("Enter new text : ")
            notes = edit_note(notes, note_id, new_title, new_message)
            save_notes(notes)
            print("Save succefull.")
        elif command == "delete":
            note_id = int(input("Please enter note ID for deleted: "))
            notes = delete_note(notes, note_id)
            save_notes(notes)
            print("Delete succefull.")
        elif command == "show":
            note_id = int(input("Please enter note ID for view: "))
            show_note(notes, note_id)
        elif command == "exit":
            break
        else:
            print("Incorrect command. Please try again")

if __name__ == "__main__":
    main()