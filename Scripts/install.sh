#! /bin/sh

echo 'Downloading Unity3D:'
curl -o unity3d.deb http://download.unity3d.com/download_unity/linux/unity-editor-5.4.2f2+20161111_amd64.deb

echo 'Installing Unity3D:'
sudo dpkg -i unity3d.deb