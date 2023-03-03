import { Component, Input } from '@angular/core';
import { User } from 'src/app/interface/user.interface';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styles: [
  ]
})
export class CardComponent {


  @Input() user: User = {
    login: '',
    name: '',
    avatar_url: '',
    followers: 0,
    following: 0,
    public_repos: 0,
    location: '',
    blog: '',
    company: '',
    email: '',
    bio: '',
    events_url: '',
    followers_url: '',
    following_url: '',
    gists_url: '',
    gravatar_id: '',
    hireable: '',
    html_url: '',
    id: 0,
    node_id: '',
    organizations_url: '',
    public_gists: 0,
    received_events_url: '',
    repos_url: '',
    site_admin: false,
    starred_url: '',
    subscriptions_url: '',
    twitter_username: '',
    type: '',
    url: '',
    created_at: new Date(),
    updated_at: new Date()
  }
}
