# Web Module
Branch created to store only what the web app needs to run in the server, this will be deleted and created back and forth everytime a new release (or advance) is done

## How to clone only this branch
To achieve this in the terminal you only need to type
```git
git clone --single-branch --branch web https://github.com/edoomm/evaseac.git
```
Which works with [1.7.10](https://github.com/git/git/blob/master/Documentation/RelNotes/1.7.10.txt) git verion and later

## Updating
This is as simple as:
```git
git pull origin web
```

# Evaseac
Project developed in collaboration with [ENCB](https://www.encb.ipn.mx/) and [ESCOM](https://www.escom.ipn.mx/), intended to serve as a way to retrieve all the work made by [Evaseac](https://www.innovacioneduencb.ipn.mx/Evaseac/), a laboratory focused on research and teaching of aquatic ecosystems health status

## Tech/Framework used
Built with
- HTML5, Javascript, PHP

## Credits
Coder:
- @edoomm