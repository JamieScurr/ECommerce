import { AppBar, Toolbar, Typography } from "@mui/material";

export default function Header() {
  return (
    <AppBar
      position="static"
      style={{ background: "white", color: "black" }}
      sx={{ mb: 4 }}
    >
      <Toolbar>
        <Typography variant="h6">Artsy Stone Store</Typography>
      </Toolbar>
    </AppBar>
  );
}
