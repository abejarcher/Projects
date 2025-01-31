import os
from os import scandir, rename
from os.path import splitext, exists, join
import shutil
import time
from shutil import move
from time import sleep

import logging
import watchdog
from watchdog.observers import Observer
from watchdog.events import FileSystemEventHandler

source_dir = "/Users/abearcher/Downloads"
dest_dir_image = "/Users/abearcher/Desktop/Photos"
dest_dir_video = "/Users/abearcher/Desktop/Videos"
dest_dir_word = "/Users/abearcher/Desktop/Word"
dest_dir_ppt = "/Users/abearcher/Desktop/PowerPoints"

def makeUnique(dest, name):
    filename, extension = splitext(name)
    counter = 1
    # if File exists, add number to end of filename
    while exists(f"{dest}/{name}"):
        name = f"{filename}({str(counter)}){extension}"
        counter += 1
    return name

def move_file(dest, entry, name):
    file_exists = os.path.exists(dest + "/" + name)
    if file_exists:
        unique_name = makeUnique(name)
        os.rename(entry, unique_name)
    shutil.move(entry, dest)

class MoverHandler(FileSystemEventHandler):
    def on_modified(self, event):
        with os.scandir(source_dir) as entries:
            for entry in entries:
                if entry.is_file():
                    name = entry.name
                    dest = source_dir
                    if name.endswith(".jpg") or name.endswith(".png") or name.endswith(".pdf") or name.endswith(".HEIC") or name.endswith(".PNG"):
                        dest = dest_dir_image
                        move_file(dest, entry, name)
                    elif name.endswith(".docx"):
                        dest = dest_dir_word
                        move_file(dest, entry, name)
                    elif name.endswith(".mp4") or name.endswith(".mov"):
                        dest = dest_dir_video
                        move_file(dest, entry, name)
                    elif name.endswith(".pptx"):
                        dest = dest_dir_ppt
                        move_file(dest, entry, name)
                    

if __name__ == "__main__":
    logging.basicConfig(level=logging.INFO,
                        format='%(asctime)s - %(message)s',
                        datefmt='%Y-%m-%d %H:%M:%S')
    path = source_dir
    event_handler = MoverHandler()
    observer = Observer()
    observer.schedule(event_handler, path, recursive= True)
    observer.start()
    try:
        while True:
            time.sleep(10)
    except KeyboardInterrupt:
        observer.stop()
    observer.join()
