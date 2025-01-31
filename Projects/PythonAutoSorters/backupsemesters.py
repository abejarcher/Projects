import os
from os import scandir, rename
from os.path import splitext, exists, join
import shutil
import time
from shutil import move
from time import sleep

source_dir = "/Users/abearcher"
backup_dir = "/Users/abearcher/OneDrive - University of Arkansas"


with os.scandir(source_dir) as entries:
    for entry in entries:
        name = entry.name
        if name.startswith("Fall20") or name.startswith("Spring20"):
            start = os.path.join(source_dir, name)
            dest = os.path.join(backup_dir, name)
            counter = 0
            while os.path.exists(dest):
                counter +=1
                new_name = f"{str(counter)}_{name}"
                dest = os.path.join(backup_dir,new_name)
            shutil.copytree(start, dest, dirs_exist_ok=False)
            

print("Task Completed")
                     