import React, { useEffect } from 'react';
import axios from 'axios';
import {
  styled,
  alpha,
  AppBar,
  Box,
  Badge,
  IconButton,
  InputBase,
  Menu,
  MenuItem,
  Toolbar,
  Typography,
  Button,
  TextField
} from '@mui/material';
import {
  AccountCircle,
  Mail as MailIcon,
  MoreVert as MoreIcon,
  Notifications as NotificationsIcon,
  Search as SearchIcon,
  Menu as MenuIcon
} from '@mui/icons-material';

const API_BASE_URL = 'https://reqres.in/api';

const Search = styled('div')(({ theme }) => ({
  position: 'relative',
  borderRadius: theme.shape.borderRadius,
  backgroundColor: alpha(theme.palette.common.white, 0.15),
  '&:hover': {
    backgroundColor: alpha(theme.palette.common.white, 0.25),
  },
  marginRight: theme.spacing(2),
  marginLeft: 0,
  width: '100%',
  [theme.breakpoints.up('sm')]: {
    marginLeft: theme.spacing(3),
    width: 'auto',
  },
}));

const SearchIconWrapper = styled('div')(({ theme }) => ({
  padding: theme.spacing(0, 2),
  height: '100%',
  position: 'absolute',
  pointerEvents: 'none',
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'center',
}));

const StyledInputBase = styled(InputBase)(({ theme }) => ({
  color: 'inherit',
  '& .MuiInputBase-input': {
    padding: theme.spacing(1, 1, 1, 0),
    paddingLeft: `calc(1em + ${theme.spacing(4)})`,
    transition: theme.transitions.create('width'),
    width: '100%',
    [theme.breakpoints.up('md')]: {
      width: '20ch',
    },
  },
}));

const getUser = async (userId: number) => {
  try {
    const response = await axios.get(`${API_BASE_URL}/users/${userId}`);
    console.log('User:', response.data);
  } catch (error) {
    console.error('Error fetching user:', error);
  }
};

const getUsers = async () => {
  try {
    const response = await axios.get(`${API_BASE_URL}/users`);
    console.log('Users:', response.data.data);
  } catch (error) {
    console.error('Error fetching users:', error);
  }
};

const getResources = async () => {
  try {
    const response = await axios.get(`${API_BASE_URL}/resources`);
    console.log('Resources:', response.data.data);
  } catch (error) {
    console.error('Error fetching resources:', error);
  }
};

const createUser = async (userData: object) => {
  try {
    const response = await axios.post(`${API_BASE_URL}/users`, userData);
    console.log('User created/updated:', response.data);
  } catch (error) {
    console.error('Error creating/updating user:', error);
  }
};

export default function PrimarySearchAppBar() {
  const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);
  const [mobileMoreAnchorEl, setMobileMoreAnchorEl] =
    React.useState<null | HTMLElement>(null);

  useEffect(() => {
    getUser(1);
    getUsers();
    getResources();

    const userData = {
      name: 'John Doe',
      email: 'john.doe@example.com',
    };

    createUser(userData);
  }, []);

  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static">
        <Toolbar>
          <IconButton
            size="large"
            edge="start"
            color="inherit"
            aria-label="open drawer"
            sx={{ mr: 2 }}
          >
            <MenuIcon />
          </IconButton>
          <Typography
            variant="h6"
            noWrap
            component="div"
            sx={{ display: { xs: 'none', sm: 'block' } }}
          >
            Test
          </Typography>
          <Search>
            <SearchIconWrapper>
              <SearchIcon />
            </SearchIconWrapper>
            <StyledInputBase
              placeholder="Search…"
              inputProps={{ 'aria-label': 'search' }}
            />
          </Search>
          <Box sx={{ flexGrow: 1 }} />
          <Box sx={{ display: { xs: 'none', md: 'flex' } }}>
            <IconButton size="large" aria-label="show 4 new mails" color="inherit">
              <Badge badgeContent={4} color="error">
                <MailIcon />
              </Badge>
            </IconButton>
            <IconButton
              size="large"
              aria-label="show 17 new notifications"
              color="inherit"
            >
              <Badge badgeContent={17} color="error">
                <NotificationsIcon />
              </Badge>
            </IconButton>
            <IconButton
              size="large"
              edge="end"
              aria-label="account of current user"
              aria-controls="primary-search-account-menu"
              aria-haspopup="true"
              color="inherit"
            >
              <AccountCircle />
            </IconButton>
          </Box>
          <Box sx={{ display: { xs: 'flex', md: 'none' } }}>
            <IconButton
              size="large"
              aria-label="show more"
              aria-controls="primary-search-account-menu-mobile"
              aria-haspopup="true"
              color="inherit"
            >
              <MoreIcon />
            </IconButton>
          </Box>
        </Toolbar>
      </AppBar>
      <br></br>

      <Typography variant="h3" sx={{ textAlign: "center" }}>
        Hello user pls sign in!
      </Typography>
      <Box
        sx={{
          display: 'flex',
          justifyContent: 'center',
          marginTop: 4
        }}
      >
        <form>
          <TextField
            label="Email"
            variant="outlined"
            margin="normal"
            fullWidth
          />
          <TextField
            label="Password"
            type="password"
            variant="outlined"
            margin="normal"
            fullWidth
          />
          <Button
            type="submit"
            variant="contained"
            color="primary"
            fullWidth
          >
            Подтвердить
          </Button>
        </form>
      </Box>
    </Box>
  );
}