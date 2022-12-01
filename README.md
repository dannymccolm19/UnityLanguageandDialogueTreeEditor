# UnityLanguageandDialogueTreeEditor
For this assignment I created two EditorWindows. 
One is a modified version of the language editor from tools 2 and the other is for editing dialogue trees.
The dialogue editor has two tabs, NPC and player.
The NPC tab is for editing the dialogue keys.
Pressing add new key will add a new key and the reverse for Remove most recent key.
Editing the property fields will change the value of that key, which can be seen in the language editor.
Note that you can not change the actual dialogue, that is done in the language editor.
The Player tab is for managing the responses to each npc dialogue.
There is a dropdown menu at the top of the tab, this contains all dialoge keys that have been created.
Selecting one will show the response options for that dialogue.
The tool is written to support a max of five responses to each line of npc dialogue, so there are five responses shown.
Each response has a property field, where you can change the value of the responses key, as well as a toggle button right next to it.
Selecting the toggle makes the selected response "active", meaning that it will show up as a response.
The dropdown menus to the right of the toggle buttons have the same options as the one at the top.
However, these dropdowns are used to select which dialogue the selected response will link to if picked.
For example, selecting "Two" in the dropdown menu next to a response means that if that response is selected by the player, 
then the npcs next dialogue will be the dialogue option at key "Two"

The language editor is very similar to the one from tools 2 but there are some changes
There is a toggle button at the top of the editor, consistent across all tabs, that is labeled "Responses"
Clicking this will allow you to edit the responses, while unselecting it will allow you to edit npc dialogue
For the npc dialogue there is a multi line text field for each npc dialogue, each labelled with the key value
For the player response there is the exact same dropdown as in the player tab of the dialogue editor.
Selecting a dialogue key will display all of the responses for that dialogue that have been enabled.
So only responses that were toggled in the dialogue editor will appear
Each response has a multi line text field to edit the string in the selected language.
