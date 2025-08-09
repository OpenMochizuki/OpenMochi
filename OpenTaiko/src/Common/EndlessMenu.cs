/*
GENERATED CODE | READ-ONLY
You can directly copy from here, or from File > Export to clipboard
*/

static bool window = true;
ImGui::SetNextWindowSize(ImVec2(163,256));
//!! You might want to use these ^^ values in the OS window instead, and add the ImGuiWindowFlags_NoTitleBar flag in the ImGui window !!

if (ImGui::Begin("window_name", &window))
{

	ImGui::SetCursorPos(ImVec2(11.5,37.5));
	ImGui::Text("Select a Difficulty:");

	ImGui::SetCursorPos(ImVec2(6.875,64));
	ImGui::PushItemWidth(150);
	static int item_current3 = 0;
	const char *items3[] = {"Soft", "Normal", "Hard", "Solid", "Burnt", "World's End"};
	ImGui::ListBox("##", &item_current3, items3, IM_ARRAYSIZE(items3));
	ImGui::PopItemWidth();

	ImGui::SetCursorPos(ImVec2(56.5,192.5));
	ImGui::Button("Select", ImVec2(50,19)); //remove size argument (ImVec2) to auto-resize

	ImGui::SetCursorPos(ImVec2(17.5,223.5));
	static bool r15 = false;
	ImGui::RadioButton("Enable Autoplay", r15);

}
ImGui::End();

/*
Reminder: some widgets may have the same label "##" (if you didn't change it), and can lead to undesired ID collisions.
More info: https://github.com/ocornut/imgui/blob/master/docs/FAQ.md#q-about-the-id-stack-system
*/